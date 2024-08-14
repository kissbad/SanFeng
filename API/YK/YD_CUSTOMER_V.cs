namespace API.YK
{
    public class YD_CUSTOMER_V
    {
        public int CUSTOMID { get; set; } 
        public string? CUSTOMNAME { get; set; }
        public string? TAXNUMBER { get; set; }
        public string? LEGALPERSON { get; set; }
        public string? CUSTOMERTYPE { get; set; }
        public string? PROVINCENAME { get; set; }
        public string? CITYNAME { get; set; }
        public string? COUNTRYNAME { get; set; }
        public string? REGISTADD { get; set; }
        public DateTime FIRSTAPPROVEDATE { get; set; }
        public string? GSPUSESTATUS { get; set; }
        public string? SAUSESTATUS { get; set; }
        public string? BACKUSESTATUS { get; set; }
    }
}
