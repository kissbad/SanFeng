using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class pub_employee
    {
        public static bool is_ckry(int employeeid) {
            string sql = @"SELECT a.employeeid FROM pub_employee a WHERE a.deptid = 9 and a.employeeid = :employeeid";
            return Oracle.ExecuteNonQuery(sql, new OracleParameter("employeeid", employeeid)) > 0;
        }
    }
}
