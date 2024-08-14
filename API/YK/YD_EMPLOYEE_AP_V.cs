using Oracle.ManagedDataAccess.Client;

namespace API.YK
{
    public class YD_EMPLOYEE_AP_V
    {
        public int EMPLOYEEID { get; set; }
        public string? EMPLOYEENAME { get; set; }
        public string? USERID { get; set; }
        public string? APTYPE { get; set; }
        public string? APVALUE { get; set; }

        public static List<YD_EMPLOYEE_AP_V> get_list(string USERID, string and) {
            string sql = @"select * from YD_EMPLOYEE_AP_V yd_view where USERID = :USERID " + and;

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("USERID", USERID)]);
            return WQH.Convert.TableToList<YD_EMPLOYEE_AP_V>(data);
        }
    }
}
