namespace API.YK
{
    public class YD_UNREC_SUDTLQRY_V
    {
        public string? DOCTYPE { get; set; }
        public DateTime CONFIRMDATE { get; set; }
        public int SUPPLYID { get; set; }
        public string? SUPPLYNAME { get; set; }
        public string? CONTACTMAN { get; set; }
        public decimal UPPAYMONEY { get; set; }
        public string? STORAGENAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? ISREGISTERFLAG { get; set; }
        public static object get_sum(string and)
        {
            string sql = @"SELECT NVL(SUM(UPPAYMONEY), 0) SUMUPPAYMONEY FROM YD_UNREC_SUDTLQRY_V yd_view where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal sumuppaymoney = Convert.ToDecimal(sum.Rows[0]["sumuppaymoney"]);

            return new { sumuppaymoney };
        }
    }
}
