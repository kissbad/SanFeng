namespace API.YK
{
    public class YD_SUCONDOC_V
    {
        public int SUCONID { get; set; }
        public int SUPPLYID { get; set; }
        public string? SUPPLYNAME { get; set; }
        public string? SIGNMAN { get; set; }
        public DateTime VALIDBEGDATE { get; set; }
        public DateTime VALIDENDDATE { get; set; }
        public string? MEMO { get; set; }
        public decimal TOTAL { get; set; }
        public DateTime CREDATE { get; set; }
        public string? INPUTMANNAME { get; set; }
        public string? AGENTNAME { get; set; }
        public string? CONTACTMAN { get; set; }
        public string? CONFIRMAN { get; set; }
        public DateTime CONFIRMDATE { get; set; }
        public string? STORAGENAME { get; set; }
        public string? INVCOMPANYNAME { get; set; }
        public string? BANKNAME { get; set; }
        public string? ACCNO { get; set; }
        public string? MAKEUPFLAG { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? ISREGISTERFLAG { get; set; }
        public string? SUPPLYERNAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public string? PURCHASERNAME { get; set; }
        public string? SETTLETYPE { get; set; }
        public string? PREPAY { get; set; }
        public static object get_sum(string and)
        {
            string sql = @"SELECT NVL(SUM(TOTAL), 0) SUMTOTAL, NVL(SUM(PREPAY), 0) SUMPREPAY FROM YD_SUCONDOC_V yd_view where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal sumtotal = Convert.ToDecimal(sum.Rows[0]["sumtotal"]);
            decimal sumprepay = Convert.ToDecimal(sum.Rows[0]["sumprepay"]);

            return new { sumtotal, sumprepay };
        }
    }
}
