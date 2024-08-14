namespace API.YK
{
    public class YD_SUDTLQRY_V
    {
        public int SUDOCID { get; set; }
        public string? SUTYPENAME { get; set; }
        public DateTime CONFIRMDATE { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? ISREGISTERFLAG { get; set; }
        public int SUDOCDTLID { get; set; }
        public int GOODSID { get; set; }
        public decimal UNITPRICE { get; set; }
        public decimal SUUNITPRICE { get; set; }
        public string? NEWPRICE { get; set; }
        public decimal GOODSQTY { get; set; }
        public decimal TOTAL_LINE { get; set; }
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
        public int SUPPLYID { get; set; }
        public string? SUPPLYNAME { get; set; }
        public string? AGENTNAME { get; set; }
        public string? CONTACTMAN { get; set; }
        public string? LOTNO { get; set; }
        public DateTime PRODDATE { get; set; }
        public DateTime INVALIDDATE { get; set; }
        public string? CONFIRMMANNAME { get; set; }
        public string? PURCHASERNAME { get; set; }
        public string? GOODSCLASSNAME { get; set; }
        public string? GOODSORGANIDEPTNAME { get; set; }
        public string? GOODSPOSITIONNAME { get; set; }
        public string? ZX_COLUMNCNAME { get; set; }
        public static object get_sum(string and)
        {
            string sql = @"SELECT NVL(SUM(TOTAL_LINE), 0) SUMTOTAL_LINE FROM YD_SUDTLQRY_V yd_view where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal sumtotal_line = Convert.ToDecimal(sum.Rows[0]["sumtotal_line"]);

            return new { sumtotal_line };
        }
    }
}
