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
    class KronosExcel
    {
        public static string DB_PATH = @"";
        public static BindingList<string> EmpList = new BindingList<string>();
        private static MyExcel.Workbook MyBook = null;
        private static MyExcel.Application MyApp = null;
        private static MyExcel.Worksheet MySheet = null;
        private static MyExcel.Worksheet MyPrevSheet = null;
        private static int lastRow = 0;
        public static void InitializeExcel(int payperiod)
        {
            MyApp = new MyExcel.Application();
            MyApp.Visible = true;
            MyBook = MyApp.Workbooks.Open("C:\\Users\\admin\\Desktop\\Productivity Report\\Test.xlsx");
            //MyBook = MyApp.Workbooks.Open(DB_PATH);
            MySheet = MyBook.Sheets[payperiod];
            MyPrevSheet = MyBook.Sheets[payperiod-1];
            lastRow = MySheet.Cells.SpecialCells(MyExcel.XlCellType.xlCellTypeLastCell).Row; 
        }

        public static void WriteToExcel(DataTable datatable)
        {
            try
            {
                int rn = 54;
                foreach (DataRow row in datatable.Rows)
                {
                    object[] array = row.ItemArray;
                    MySheet.Cells[rn, 1] = array[0];
                    MySheet.Cells[rn, 5] = array[1];
                    MySheet.Cells[rn, 6] = array[2];
                    MySheet.Cells[rn, 7] = array[3];
                    MySheet.Cells[rn, 8] = array[4];
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
