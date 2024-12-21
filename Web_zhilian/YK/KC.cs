using Oracle.ManagedDataAccess.Client;
using static NPOI.HSSF.Util.HSSFColor;

namespace Web_zhilian.YK
{
    public class KC
    {
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? HOLDERSNAME { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public string? GOODSUNIT { get; set; }
        public int GOODSQTY { get; set; }
        public string? LOTNO { get; set; }
        public DateTime PRODDATE { get; set; }
        public DateTime INVALIDDATE { get; set; }

        public static List<KC> getList(string view, string goodsname, string lotno, string holdersname, string factoryname)
        {
            string sql = @"select * from " + view + " where nvl(goodsname, ' ') like '%' ||:goodsname || '%' and nvl(lotno, ' ') like '%' ||:lotno || '%' " +
                "and nvl(holdersname,' ') like '%'||:holdersname||'%' and nvl(factoryname,' ') like '%'||:factoryname||'%' ";
            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("goodsname", goodsname),
                new OracleParameter("lotno", lotno),
                new OracleParameter("holdersname", holdersname),
                new OracleParameter("factoryname", factoryname)]);
            return WQH.Convert.TableToList<KC>(data);
        }
    }
}
