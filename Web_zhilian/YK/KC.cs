using Oracle.ManagedDataAccess.Client;

namespace Web_zhilian.YK
{
    public class KC
    {
        public int GOODSID { get; set; }
        public string? GOODSNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? GOODSUNIT { get; set; }
        public int GOODSQTY { get; set; }
        public string? LOTNO { get; set; }
        public DateTime PRODDATE { get; set; }
        public DateTime INVALIDDATE { get; set; }

        public static List<KC> getList(string view)
        {
            string sql = @"select * from " + view;
            var splist = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("view", view) });
            return WQH.Convert.TableToList<KC>(splist);
        }
    }
}
