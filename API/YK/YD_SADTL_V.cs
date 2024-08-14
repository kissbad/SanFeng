using Oracle.ManagedDataAccess.Client;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace API.YK
{
    public class YD_SADTL_V
    {
        public int SALESID { get; set; }
        public int SALESDTLID { get; set; }
        public int GOODSID { get; set; } 
        public decimal UNITPRICE { get; set; }
        public int GOODSQTY{ get; set; }
        public decimal TOTAL_LINE { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? GOODSNAME { get; set; }
        public string? CURRENCYNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? GOODSUNIT { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public int PACKSIZE { get; set; }
        public string? PACKNAME{ get; set; }
        public string? HOLDERSNAME{ get; set; }
        public string? FACTORYNAME{ get; set; }
        public string? LOTNO{ get; set; }
        public DateTime INVALIDDATE{ get; set; }
        public DateTime PRODDATE { get; set; }
        public string? STORAGENAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public string? GOODSCLASSNAME { get; set; }
        public string? GOODSORGANIDEPTNAME { get; set; }
        public string? GOODSPOSITIONNAME { get; set; }
        public string? ZX_COLUMNCNAME { get; set; }

        public static List<YD_SADTL_V> get_list(int salesid, string and) {
            string sql = @"select * from YD_SADTL_V yd_view where salesid = :salesid " + and;

            var YD_SADTL_V = Oracle.ExecuteDataTable(sql, [new OracleParameter("salesid", salesid)]);
            return WQH.Convert.TableToList<YD_SADTL_V>(YD_SADTL_V);
        }
    }
}
