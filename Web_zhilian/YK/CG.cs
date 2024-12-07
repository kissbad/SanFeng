using Oracle.ManagedDataAccess.Client;

namespace Web_zhilian.YK
{
    public class CG
    {
        public DateTime CREDATE { get; set; }
        public int SUPPLYID { get; set; }
        public string? SUPPLYNAME { get; set; }
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? GOODSUNIT { get; set; }
        public string? LOTNO { get; set; }
        public DateTime INVALIDDATE { get; set; }
        public int GOODSQTY { get; set; }
        public decimal UNITPRICE { get; set; }
        public decimal TOTAL_LINE { get; set; }

        public static List<CG> getList(string view)
        {
            string sql = @"select * from " + view;
            var splist = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("view", view) });
            return WQH.Convert.TableToList<CG>(splist);
        }
    }
}
