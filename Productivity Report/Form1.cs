using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productivity_Report.DataAccess;
using Productivity_Report.Business;
using Productivity_Report.Properties;

namespace Productivity_Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            MckessonExcel.DB_PATH = textBox_ExcelFileName.Text;
            LoadComboItems();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdRptBL prodrptbl = new ProdRptBL();
            System.Data.DataTable IPRev, ClinicRev, TotalRev, ADCAcute, ADCGPU, TotalRegs = new System.Data.DataTable();

            ComboBoxItem cb1selection = (ComboBoxItem)comboBox1.SelectedItem;
            ComboBoxItem cb2selection = (ComboBoxItem)comboBox2.SelectedItem;
            ComboBoxItem cb3selection = (ComboBoxItem)comboBox3.SelectedItem;

            int selectedFiscalYear = cb2selection.Value;
            int selectedPayPeriod = cb1selection.Value;
            int selectedFacility = cb3selection.Value;

            //return pay period date based on year
            string selectedPPEndDate = PayPeriodDates.GetPayPeriodEndDate(selectedFiscalYear, selectedPayPeriod);
            IPRev = prodrptbl.PopulateDataTables(selectedFacility, selectedFiscalYear.ToString() + "0101", selectedPPEndDate, "Rpt1", "IPRev");
            ClinicRev = prodrptbl.PopulateDataTables(selectedFacility, selectedFiscalYear.ToString() + "0101", selectedPPEndDate, "Rpt1", "ClinicRev");
            TotalRev = prodrptbl.PopulateDataTables(selectedFacility, selectedFiscalYear.ToString() + "0101", selectedPPEndDate, "Rpt1", "TotalRev");
            ADCAcute = prodrptbl.PopulateDataTables(selectedFacility, selectedFiscalYear.ToString() + "0101", selectedPPEndDate, "Rpt2", "ADCAcute");
            ADCGPU = prodrptbl.PopulateDataTables(selectedFacility, selectedFiscalYear.ToString() + "0101", selectedPPEndDate, "Rpt2", "ADCGPU");
            TotalRegs = prodrptbl.PopulateDataTables(selectedFacility, selectedFiscalYear.ToString() + "0101", selectedPPEndDate, "Rpt3", "");

            //get kronos data
            //string prevCheckDate = PayPeriodDates.GetPayPeriodCheckDate(selectedFiscalYear, selectedPayPeriod - 1);
            string startPPDate = PayPeriodDates.GetPayPeriodStartDate(selectedFiscalYear, selectedPayPeriod);
            string endPPDate = PayPeriodDates.GetPayPeriodEndDate(selectedFiscalYear, selectedPayPeriod);

            string selectedKronosFacility = "";
            switch (selectedFacility)
            {
                case 103:
                    selectedKronosFacility = "NWT";
                    break;
            }
                

            System.Data.DataTable KronosData = new System.Data.DataTable();
            KronosData = prodrptbl.PopulateKronosDataTables(selectedKronosFacility, selectedFiscalYear.ToString(), startPPDate, endPPDate);

            //add mckesson data to excel
            if (selectedPayPeriod == 1)
            {
                MckessonExcel.InitializeExcel(selectedFiscalYear, selectedPayPeriod);
                MckessonExcel.WriteToExcel(IPRev, ClinicRev, TotalRev, ADCAcute, ADCGPU, TotalRegs);
            }
            else
            {
                MckessonExcel.InitializeExcel(selectedFiscalYear, selectedPayPeriod);
                MckessonExcel.CopyToExcel();
                MckessonExcel.WriteToExcel(IPRev, ClinicRev, TotalRev, ADCAcute, ADCGPU, TotalRegs);
            }

            //add kronos data to excel
            MckessonExcel.WriteKronosToExcel(KronosData);

            //Show data
            string message = "";
            message += BuildMessage(IPRev);
            message += BuildMessage(ClinicRev);
            message += BuildMessage(TotalRev);
            message += BuildMessage(ADCAcute);
            message += BuildMessage(ADCGPU);
            message += BuildMessage(TotalRegs);

            //DataTable dt = PopulateDataTables("20140101", "20140817", "Rpt1", "IPRev");

            //MessageBox.Show(message);
        }

        public class ComboBoxItem
        {
             public int Value;
            public string Text;

            public ComboBoxItem(int val, string text)
            {
                Value = val;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }

        }

        public void LoadComboItems()
        {
            FillPayPrdDDL();
            FillYearDDL();
            FillFacilityDDL();
        }

        public void FillFacilityDDL()
        {
            comboBox3.Items.Add(new ComboBoxItem(103, "Newton"));
        }

        public void FillYearDDL()
        {

            comboBox2.Items.Add(new ComboBoxItem(2014, "Fiscal Year 2014"));
            comboBox2.Items.Add(new ComboBoxItem(2015, "Fiscal Year 2015"));
        }

        public void FillPayPrdDDL()
        {
            for (int i = 1; i < 27; i++)
            {
                comboBox1.Items.Add(new ComboBoxItem(i, "Pay Period " + i));
            }

        }

        public string BuildMessage(DataTable datatable)
        {
            int i = 0;
            string builtString = "";
            foreach (DataRow row in datatable.Rows)
            {
                object[] array = row.ItemArray;
                builtString += array[i].ToString() + " ";
            }

            return builtString;
        }

       private void button_ExcelFile_Click(object sender, EventArgs e)
       {
           OpenFileDialog ExcelDialog = new OpenFileDialog();
           ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
           ExcelDialog.InitialDirectory = @"C:\";
           ExcelDialog.Title = "Select your excel";
           if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
               MckessonExcel.DB_PATH = ExcelDialog.FileName;
               textBox_ExcelFileName.Text = ExcelDialog.FileName;
               textBox_ExcelFileName.ReadOnly = true;
               textBox_ExcelFileName.Click -= button_ExcelFile_Click;
               //tabControl1.Selecting -= tabControl1_Selecting;
               button_ExcelFile.Enabled = false;
               //Excel.InitializeExcel();
               //dataGridEmpList.DataSource = MyExcel.ReadMyExcel();
               //tblLytAddMem.Visible = true;
               Settings.Default.Save();
           }
       }

    }
}
