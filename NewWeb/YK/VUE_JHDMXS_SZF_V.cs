using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class VUE_JHDMXS_SZF_V
    {
        public int PICKDOCID { get; set; }
        public int JHMXS { get; set; }
        public int JHKCS { get; set; }
        public string? rq { get; set; }
        public static VUE_JHDMXS_SZF_V get_data(int task)
        {
            string sql = @"select pickdocid,jhmxs,jhkcs,to_char(sysdate,'yyyy-MM-dd hh24:mi:ss')as rq from VUE_JHDMXS_SZF_V WHERE PICKDOCID = :task";
            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("task", task)]);
            return WQH.Convert.TableToList<VUE_JHDMXS_SZF_V>(data)[0];
        }
    }
}
