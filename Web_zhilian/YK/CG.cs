using Oracle.ManagedDataAccess.Client;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Web_zhilian.YK
{
    public class CG
    {
        public DateTime CREDATE { get; set; }
        public string? COMEFROM { get; set; }
        public string? SUPPLYNAME { get; set; }
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? HOLDERSNAME { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? GOODSUNIT { get; set; }
        public string? LOTNO { get; set; }
        public DateTime PRODDATE { get; set; }
        public DateTime INVALIDDATE { get; set; }
        public int GOODSQTY { get; set; }
        public decimal UNITPRICE { get; set; }
        public decimal TOTAL_LINE { get; set; }

        public static List<CG> getList(string view, DateTime startdate, DateTime enddate, string goodsname, string lotno, string holdersname, string factoryname)
        {
            string sql = @"select * from " + view + " where CREDATE between :startdate and :enddate " +
                "and nvl(goodsname,' ') like '%'||:goodsname||'%' and nvl(lotno,' ') like '%'||:lotno||'%' " +
                "and holdersname like '%'||:holdersname||'%' and factoryname like '%'||:factoryname||'%' ";
            var data = Oracle.ExecuteDataTable(sql,
                [new OracleParameter("startdate", startdate),
                    new OracleParameter("enddate", enddate),
                    new OracleParameter("goodsname", goodsname),
                    new OracleParameter("lotno", lotno),
                    new OracleParameter("holdersname", holdersname),
                    new OracleParameter("factoryname", factoryname)]);
            return WQH.Convert.TableToList<CG>(data);
        }
    }
}
