
namespace API.YK
{
    public class YD_UNREC_SADTLQRY_V
    {
        public DateTime CREDATE { get; set; } 
        public int CUSTOMID { get; set; } 
        public string? CUSTOMNAME { get; set; }
        public string? CONTACTMAN { get; set; }
        public string? MERMECDEPTNAME { get; set; }
        public string? BIOSSALERNAME { get; set; }
        public string? SALERMASTERNAME { get; set; }
        public decimal TOTAL_LINE { get; set; }
        public string? DOCTYPE { get; set; }
        public string? STORAGENAME { get; set; }
        public string? GOODSDEPTNAME { get; set; }
        public decimal PAYTOTAL_LINE { get; set; }
        public string? ISRECFLAG { get; set; }
        public string? ISREGISTERFLAG { get; set; }
        
        public static object get_sum(string and)
        {
            string sql = @"SELECT NVL(SUM(TOTAL_LINE), 0) SUMTOTAL_LINE,
       NVL(SUM(PAYTOTAL_LINE), 0) SUMPAYTOTAL_LINE
  FROM YD_UNREC_SADTLQRY_V yd_view where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal sumtotal_line = Convert.ToDecimal(sum.Rows[0]["sumtotal_line"]);
            decimal sumpaytotal_line = Convert.ToDecimal(sum.Rows[0]["sumpaytotal_line"]);

            return new { sumtotal_line, sumpaytotal_line };
        }
    }
}
