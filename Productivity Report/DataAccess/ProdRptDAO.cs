using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Productivity_Report.DataAccess
{
    class ProdRptDAO
    {
        public DataTable PopulateDataTables(int facility, string startppdate, string currentppdate, string report, string code)
        {
            DataTable dt = new DataTable();
            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db1"].ToString()))
            {
                using (var cmd = new SqlCommand("dbo.[sproc1]", cn) { CommandType = CommandType.StoredProcedure })
                {
                    cn.Open();
                    cmd.Parameters.AddWithValue("@Facility", facility);
                    cmd.Parameters.AddWithValue("@StartPP", startppdate);
                    cmd.Parameters.AddWithValue("@CurrPP", currentppdate);
                    cmd.Parameters.AddWithValue("@Report", report);
                    cmd.Parameters.AddWithValue("@Code", code);

                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        // Do some logging or something. 
                        MessageBox.Show("There was an error accessing your data. DETAIL: " + e.ToString());
                    }
                }
            }
            return dt;
        }

        public DataTable PopulateKronosDataTables(string facility, string year, string ppstartdate, string ppenddate)
        {
            DataTable dt = new DataTable();
            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db2"].ToString()))
            {
                using (var cmd = new SqlCommand("dbo.[sproc2]", cn) { CommandType = CommandType.StoredProcedure })
                {
                    cn.Open();
                    cmd.Parameters.AddWithValue("@Facility", facility);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@PrevCheckDate", ppstartdate);
                    cmd.Parameters.AddWithValue("@CurrCheckDate", ppenddate);

                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (SqlException e)
                    {
                        // Do some logging or something. 
                        MessageBox.Show("There was an error accessing your data. DETAIL: " + e.ToString());
                    }
                }
            }
            return dt;
        }
    }
}
