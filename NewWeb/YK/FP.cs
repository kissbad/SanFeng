using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class FP
    {
        public string sasettleid { get; set; }
        public string zx_fpdz { get; set; }

        public static List<FP> get_FP_url(string sasettleid)
        {
            string sql = @"SELECT distinct sasettleid,substr(zx_fpdz,instr(zx_fpdz,',',-1) + 1) as zx_fpdz FROM bms_sa_settle_dTL where sasettleid = :sasettleid and zx_fpdz is not null";
            var fp = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("sasettleid", sasettleid) });
            return WQH.Convert.TableToList<FP>(fp);
        }
    }
}
