namespace API.YK
{
    public class YD_INSTANCE_WAIT_V
    {
        public int INSTTYPE { get; set; }
        public int INSTID { get; set; }
        public int INSTDTLID { get; set; }
        public string? PNAME { get; set; }
        public string? OPNAME { get; set; }
        public string? ENTRYDESC { get; set; }
        public int DOCID { get; set; }
        public DateTime CREDATE { get; set; }
        public string? EMPLOYEENAMES { get; set; }
        public string? ROLEEMPLOYEENAMES { get; set; }
        public static object get_sum(string and)
        {
            string sql = @"SELECT COUNT(1) as count FROM YD_INSTANCE_WAIT_V where 1=1 " + and;

            var sum = Oracle.ExecuteDataTable(sql);

            decimal count = Convert.ToDecimal(sum.Rows[0]["count"]);

            return new { count };
        }
    }
}
