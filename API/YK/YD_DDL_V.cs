using Oracle.ManagedDataAccess.Client;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace API.YK
{
    public class YD_DDL_V
    {
        public int SYSID { get; set; }
        public int DDLID { get; set; }
        public string DDLNAME { get; set; }

        public static List<YD_DDL_V> get_yd_ddl_v(int sysid) {
            string sql = @"select sysid, ddlid, ddlname from yd_ddl_v yd_view where sysid = :sysid";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("sysid", sysid)]);
            return WQH.Convert.TableToList<YD_DDL_V>(data);
        }
    }
}
