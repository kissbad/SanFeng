using Oracle.ManagedDataAccess.Client;

namespace NewWeb.YK
{
    public class VUE_BHD_SZF_V
    {
        public string? STORERNAME { get; set; }
        public string? CREDATE { get; set; }
        public int STADJUSTID { get; set; }
        public string SOURCEID { get; set; }
        public string? HPXX { get; set; }
        public string? PHXX { get; set; }
        public string? SL { get; set; }
        public string? POSNO { get; set; }
        public string? STHOUSENAME { get; set; }
        public string? NEWPOSNO { get; set; }
        public string? NEWSTHOUSENAME { get; set; }
        public string? PRINTCOUNT { get; set; }
        public DateTime PRINTDATE { get; set; }
        public int PRINTMANID { get; set; }

        public static VUE_BHD_SZF_V get_date(int task)
        {
            string sql = @"select * from vue_bhd_szf_v where rownum = 1 and stadjustid = :stadjustid";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("stadjustid", task)]);
            return WQH.Convert.TableToList<VUE_BHD_SZF_V>(data)[0];
        }

        public static int first_bhd()
        {
            string sql = @"select stadjustid from vue_bhd_szf_v a where rownum = 1 and printcount is null and printdate is null and printmanid is null";

            var data = Oracle.ExecuteDataTable(sql);
            if (data.Rows.Count <= 0) throw new Exception("无待补货单！！");

            return Convert.ToInt32(data.Rows[0][0]);
        }
    }
}
