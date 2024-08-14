using Oracle.ManagedDataAccess.Client;

namespace API.YK.ZhiLian
{
    public class wqh_bx_kc
    {
        public DateTime INV_DATE { get; set; } 
        public int PRODUCT_ALIAS_NUMBER { get; set; }
        public string? ITEM_NAME { get; set; }
        public string? PRODUCTSIZE { get; set; }
        public string? LOTNO { get; set; }
        public int QTY { get; set; }
        public string? PRODUCTUOM { get; set; }
        public DateTime EFFECTIVEDATE { get; set; }
        public decimal PRICE { get; set; }
        public string? MANUFACTURER { get; set; }
        public static List<wqh_bx_kc> get_list()
        {
            string? sql = @"select * from wqh_bx_kc ";

            var data = Oracle.ExecuteDataTable(sql);
            return WQH.Convert.TableToList<wqh_bx_kc>(data);
        }
    }
}
