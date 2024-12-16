using Oracle.ManagedDataAccess.Client;

namespace Web_zhilian.YK
{
    public class KC
    {
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public string? GOODSUNIT { get; set; }
        public int GOODSQTY { get; set; }
        public string? LOTNO { get; set; }
        public DateTime PRODDATE { get; set; }
        public DateTime INVALIDDATE { get; set; }

        public static List<KC> getList(string view,string keyword)
        {
            string sql = @"select * from " + view + " where goodsname like '%'||:keyword||'%' or lotno like '%'||:keyword||'%'";
            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("keywod", keyword)]);
            return WQH.Convert.TableToList<KC>(data);
        }
    }
}
