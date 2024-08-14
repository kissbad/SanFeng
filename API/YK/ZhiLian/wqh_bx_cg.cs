using Oracle.ManagedDataAccess.Client;

namespace API.YK.ZhiLian
{
    public class wqh_bx_cg
    {
        public DateTime SALETO_DATE { get; set; }
        public int SUPPLY_ACCOUNT_NUMBER { get; set; }
        public string? SUPPLY_ACCOUNT_NAME { get; set; }
        public int PRODUCT_ALIAS_NUMBER { get; set; }
        public string? PRODUCT_ALIAS_NAME { get; set; }
        public string? PRODUCT_ALIAS_SIZE { get; set; }
        public string? PRODUCT_LOTNO { get; set; }
        public int SALETO_QTY { get; set; }
        public string? PRODUCT_ALIAS_UOM { get; set; }
        public decimal SALETO_PRICE { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
        public string? MANUFACTOR { get; set; }
        public decimal AMOUNT { get; set; }

        public static List<wqh_bx_cg> get_list(DateTime startdate)
        {
            string? sql = @"select * from wqh_bx_cg where SALETO_DATE > :SALETO_DATE";

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("SALETO_DATE", startdate)]);
            return WQH.Convert.TableToList<wqh_bx_cg>(data);
        }
    }
}
