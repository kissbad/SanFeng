using Oracle.ManagedDataAccess.Client;

namespace Web_zhilian.YK
{
    public class XS
    {
        public DateTime CREDATE { get; set; } 
        public int SALESID { get; set; }
        public int CUSTOMID { get; set; }
        public string? CUSTOMNAME { get; set; }
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public string? GOODSUNIT { get; set; }
        public int GOODSQTY { get; set; }
        public decimal UNITPRICE { get; set; }
        public decimal TOTAL_LINE { get; set; }
        public string? LOTNO { get; set; }
        public DateTime PRODDATE { get; set; }
        public DateTime INVALIDDATE { get; set; }

        public static List<XS> getList(string view, DateTime startdate, DateTime enddate,string keyword)
        {
            string sql = @"select * from " + view + " where CREDATE between :startdate and :enddate and  (nvl(goodsname,' ') like '%'||:keyword||'%' or nvl(lotno,' ') like '%'||:keyword||'%') ";
            var data = Oracle.ExecuteDataTable(sql, 
                [new OracleParameter("startdate", startdate), 
                new OracleParameter("enddate", enddate),
                new OracleParameter("keywod", keyword),
                new OracleParameter("keywod", keyword)]);
            return WQH.Convert.TableToList<XS>(data);
        }
    }
}
