using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace NewWeb.YK
{
    public class pub_employee
    {
        public static bool is_ckry(int employeeid) {
            string sql = @"SELECT a.employeeid FROM pub_employee a WHERE a.deptid = 9 and a.employeeid = :employeeid";
            DataTable data = Oracle.ExecuteDataTable(sql, new OracleParameter("employeeid", employeeid));
            return data.Rows.Count > 0;
        }
    }
}
