using Oracle.ManagedDataAccess.Client;

namespace API.YK
{
    public class YD_SUCONDTL_V
    {
        public int SUCONID { get; set; }
        public int SUCONDTLID { get; set; }
        public int GOODSID { get; set; }
        public decimal UNITPRICE { get; set; }
        public decimal SUUNITPRICE { get; set; }
        public string? ISMAKEUPFLAG { get; set; }
        public string? USESTATUS { get; set; }
        public string? REUSESTATUS { get; set; }
        public string? RGUSESTATUS { get; set; }
        public int GOODSQTY { get; set; }
        public decimal TOTAL_LINE { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? GOODSNAME { get; set; }
        public string? CURRENCYNAME { get; set; }
        public string? GOODSTYPE { get; set; }
        public string? GOODSUNIT { get; set; }
        public string? APPROVEDOCNO { get; set; }
        public int PACKSIZE { get; set; }
        public string? PACKNAME { get; set; }
        public string? HOLDERSNAME { get; set; }
        public string? FACTORYNAME { get; set; }
        public string? STORAGENAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public decimal SALESTAXRATE { get; set; }
        public string? GOODSCLASSNAME { get; set; }
        public string? GOODSORGANIDEPTNAME { get; set; }
        public string? GOODSPOSITIONNAME { get; set; }
        public string? ZX_COLUMNCNAME { get; set; }

        public static List<YD_SUCONDTL_V> get_list(int suconid, string and)
        {
            string sql = @"select * from YD_SUCONDTL_V yd_view where suconid = :suconid " + and;

            var data = Oracle.ExecuteDataTable(sql, [new OracleParameter("salesid", suconid)]);
            return WQH.Convert.TableToList<YD_SUCONDTL_V>(data);
        }
    }
}
