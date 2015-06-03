using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExcel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Productivity_Report
{
    class MckessonExcel
    {
        public static string DB_PATH = @"";
        private static int payperiod = 0;
        private static int year = 0;
        public static BindingList<string> EmpList = new BindingList<string>();
        private static MyExcel.Workbook MyBook = null;
        private static MyExcel.Application MyApp = null;
        private static MyExcel.Worksheet MySheet = null;
        private static MyExcel.Worksheet MyPrevSheet = null;
        private static int lastRow = 0;
        
        public static void InitializeExcel(int yearValue, int payperiodValue)
        {
            MyApp = new MyExcel.Application();
            MyApp.Visible = true;
            payperiod = payperiodValue;
            year = yearValue;
            //MyBook = MyApp.Workbooks.Open("C:\\Users\\admin\\Desktop\\Productivity Report\\Test.xlsx");
            MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = MyBook.Sheets[payperiod];
            if (payperiod != 1)
            {
                MyPrevSheet = MyBook.Sheets[payperiod - 1];
            }
            
            lastRow = MySheet.Cells.SpecialCells(MyExcel.XlCellType.xlCellTypeLastCell).Row;
            MySheet.Activate();
        }

        public static void CopyToExcel()
        {
            int prevpayperiod = payperiod - 1;

            try
            {
                //MyExcel.Range from = MyBook.Sheets[prevpayperiod].Range("E36");
                //MyExcel.Range to = MyBook.Sheets[payperiod].Range("D36");
                //from.Copy(to);

                MyBook.Sheets[payperiod].Range("D32").Value = MyBook.Sheets[prevpayperiod].Range("E32").Value;

                MyBook.Sheets[payperiod].Range("D33").Value = MyBook.Sheets[prevpayperiod].Range("E33").Value;

                MyBook.Sheets[payperiod].Range("D34").Value = MyBook.Sheets[prevpayperiod].Range("E34").Value;

                MyBook.Sheets[payperiod].Range("D37").Value = MyBook.Sheets[prevpayperiod].Range("E37").Value;

                int prevPatDays = Convert.ToInt32(MyPrevSheet.get_Range("E37").Cells.Value);
                int currPatDays = prevPatDays + 14;
                MyBook.Sheets[payperiod].Range("E37").Value = currPatDays;

                MyBook.Sheets[payperiod].Range("F37").Value = (currPatDays - prevPatDays);

                MyBook.Sheets[payperiod].Range("D39").Value = MyBook.Sheets[prevpayperiod].Range("E39").Value;

                MyBook.Sheets[payperiod].Range("D40").Value = MyBook.Sheets[prevpayperiod].Range("E40").Value;

                MyBook.Sheets[payperiod].Range("D43").Value = MyBook.Sheets[prevpayperiod].Range("E43").Value;

                MyBook.Sheets[payperiod].Range("D44").Value = MyBook.Sheets[prevpayperiod].Range("E44").Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
            }
        }

        public static void WriteToExcel(DataTable IPRev, DataTable ClinicRev, DataTable TotalRev, DataTable ADCAcute, DataTable ADCGPU, DataTable TotalRegs)
        {
            try
            {
                string currYTD = PayPeriodDates.GetPayPeriodEndDate(year, payperiod);
                string yr = currYTD.Substring(0, 4);
                string day = currYTD.Substring(6, 2);
                string month = currYTD.Substring(4, 2);
                string parsedCurrYTD = @"" + month + "/" + day + "/" + year;
                string parsedPrevYTD = @"";
                if (payperiod == 1 && year == 2015)
                {
                    //Get Previous Sheet YTD Date
                    //parsedPrevYTD = @"01/01/" + year;
                    parsedPrevYTD = @"12/21/" + (year-1);
                    MyBook.Sheets[payperiod].Range("D32").Value = "YTD" + Environment.NewLine + parsedPrevYTD;
                    //Get  Current Sheet YTD # Days
                    MyBook.Sheets[payperiod].Range("E37").Value = (Convert.ToDateTime(parsedCurrYTD) - Convert.ToDateTime(parsedPrevYTD)).TotalDays;
                }
                else
                {
                    //Get Previous YTD Date
                    parsedPrevYTD = Convert.ToDateTime(parsedCurrYTD).AddDays(-14).ToString("MM/dd/yyyy");
                    MyBook.Sheets[payperiod].Range("D32").Value = "YTD" + Environment.NewLine + parsedPrevYTD;
                    //Get Current Sheet YTD # Days
                    int prevPatDays = Convert.ToInt32(MyPrevSheet.get_Range("E37").Cells.Value);
                    MyBook.Sheets[payperiod].Range("E37").Value = (Convert.ToDateTime(parsedCurrYTD) - Convert.ToDateTime(parsedPrevYTD)).TotalDays + prevPatDays;
                }

                //MyBook.Sheets[payperiod].Range("D36").Value = "YTD" + Environment.NewLine + parsedPrevYTD;                                          // 01/01/2015 - For PP1, this is start of new year
                MyBook.Sheets[payperiod].Range("E32").Value = "YTD" + Environment.NewLine + parsedCurrYTD;                                          // 01/09/2015 - PP1 check date

               

                MyBook.Sheets[payperiod].Range("F37").Value = (Convert.ToDateTime(parsedCurrYTD) - Convert.ToDateTime(parsedPrevYTD)).TotalDays;    // 8 - Number of days 
                MyBook.Sheets[payperiod].Range("D45").Value = payperiod;
                MyBook.Sheets[payperiod].Range("A47").Value = "Pay Period " + payperiod + " Data";

                

                MySheet.Cells[33, 5] = ParseValue(IPRev);
                MySheet.Cells[44, 5] = ParseValue(ClinicRev);
                MySheet.Cells[34, 5] = ParseValue(TotalRev);
                MySheet.Cells[39, 5] = ParseValue(ADCAcute);
                MySheet.Cells[40, 5] = ParseValue(ADCGPU);
                MySheet.Cells[43, 5] = ParseValue(TotalRegs);
                //MyBook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
            }
        }

        public static void WriteKronosToExcel(DataTable datatable)
        {
            try
            {
                int rn = 50;
                
                foreach (DataRow row in datatable.Rows)
                {
                    object[] array = row.ItemArray;
                    MySheet.Cells[rn, 1] = array[0];    //Dept
                    MySheet.Cells[rn, 5] = array[1];    //WorkedHours
                    MySheet.Cells[rn, 6] = array[2];    //OTHours
                    MySheet.Cells[rn, 7] = array[3];    //PaidHours
                    MySheet.Cells[rn, 9] = array[4];    //CompTotal

                    if (payperiod > 1)
                    {
                        double totalWorkedHrs = 0.00;
                        double totalOtHrs = 0.00;
                        double totalPaidHrs = 0.00;

                        //for (int i = payperiod-(payperiod-1); i > 0; i--)
                        //{
                        //     //totalWorkedHrs = 0.00;
                        //     //totalOtHrs = 0.00;
                        //     //totalPaidHrs = 0.00;
                        //    totalWorkedHrs += (double)MyBook.Sheets[i].Range("J" + rn).Value;
                        //    totalOtHrs += (double)MyBook.Sheets[i].Range("K" + rn).Value;
                        //    totalPaidHrs += (double)MyBook.Sheets[i].Range("N" + rn).Value;
                        //}

                        //Add total from prev worksheet accumulator
                        totalWorkedHrs += (double)MyBook.Sheets[payperiod-1].Range("J" + rn).Value;
                        totalOtHrs += (double)MyBook.Sheets[payperiod - 1].Range("K" + rn).Value;
                        totalPaidHrs += (double)MyBook.Sheets[payperiod - 1].Range("N" + rn).Value;

                        //Add current worksheet numbers
                        totalWorkedHrs += Convert.ToDouble(array[1]);
                        totalOtHrs += Convert.ToDouble(array[2]);
                        totalPaidHrs += Convert.ToDouble(array[3]);
                        MyBook.Sheets[payperiod].Range("J" + rn).Value = totalWorkedHrs;
                        MyBook.Sheets[payperiod].Range("K" + rn).Value = totalOtHrs;
                        MyBook.Sheets[payperiod].Range("N" + rn).Value = totalPaidHrs;
                    }

                    else
                    {
                        MySheet.Cells[rn, 10] = array[1];    //WorkedHours
                        MySheet.Cells[rn, 11] = array[2];    //OTHours
                        MySheet.Cells[rn, 14] = array[3];    //PaidHours
                    }

                    

                    rn += 2;
                }
                //MyBook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString());
            }
        }

        public static string ParseValue(DataTable datatable)
        {
            int i = 0;
            string parsedValue = "";
            foreach (DataRow row in datatable.Rows)
            {
                object[] array = row.ItemArray;
                parsedValue += array[i].ToString() + " ";
            }

            return parsedValue;
        }

       
    }
}
