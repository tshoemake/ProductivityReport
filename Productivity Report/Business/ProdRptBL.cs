using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Productivity_Report.DataAccess;
using System.Data;

namespace Productivity_Report.Business
{
    class ProdRptBL
    {
        ProdRptDAO PrdRptDAO = new ProdRptDAO();
        public DataTable PopulateDataTables(int facility, string startppdate, string currentppdate, string report, string code)
        {
            return PrdRptDAO.PopulateDataTables(facility, startppdate, currentppdate, report, code);
        }

        public DataTable PopulateKronosDataTables(string facility, string year, string ppstartdate, string ppenddate)
        {
            return PrdRptDAO.PopulateKronosDataTables(facility, year, ppstartdate, ppenddate);
        }
    }
}
