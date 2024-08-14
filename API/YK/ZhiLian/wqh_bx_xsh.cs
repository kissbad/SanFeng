using Oracle.ManagedDataAccess.Client;

namespace API.YK.ZhiLian
{
    public class wqh_bx_xsh
    {
        public DateTime SALETO_DATE { get; set; } 
        public string? SALETO_NAME { get; set; }
        public int PRODUCT_ALIAS_NUMBER { get; set; }
        public string? ITEM_NAME { get; set; }
        public string? PRODUCTSIZE { get; set; }
        public string? LOTNO { get; set; }
        public int QTY { get; set; }
        public string? PRODUCTUOM { get; set; }
        public decimal PRICE { get; set; }
        public string? ADDRESS { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
        public string? MANUFACTURER { get; set; }
        public decimal AMOUNT { get; set; }

        public static List<wqh_bx_xsh> get_list(DateTime startdate)
        {
            string? sql = @"select * from wqh_bx_xsh where SALETO_DATE > :SALETO_DATE";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("SALETO_DATE", startdate)]);
            return WQH.Convert.TableToList<wqh_bx_xsh>(data);
        }
    }
}
