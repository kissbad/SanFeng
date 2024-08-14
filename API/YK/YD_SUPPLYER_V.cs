using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;

namespace API.YK
{
    public class YD_SUPPLYER_V
    {
        public int SUPPLYID { get; set; }
        public string? SUPPLYNAME { get; set; }
        public string? TAXNUMBER { get; set; }
        public string? LEGALPERSON { get; set; }
        public string? PROVINCENAME { get; set; }
        public string? CITYNAME { get; set; }
        public string? COUNTRYNAME { get; set; }
        public string? REGISTADD { get; set; }
        public DateTime FIRSTAPPROVEDATE { get; set; }
        public string? GSPUSESTATUS { get; set; }
        public string? SUUESSTATUS { get; set; }
        public string? BACKUSESTATUS { get; set; }
    }
}
