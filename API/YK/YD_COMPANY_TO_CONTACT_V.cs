using System.Data;

namespace API.YK
{
    public class YD_COMPANY_TO_CONTACT_V
    {
        public int CONTACTPANYID { get; set; }
        public int COMPANYID { get; set; }
        public string? COMPANYNAME { get; set; }
        public int CONTACTID { get; set; }
        public string? USESTATUS { get; set; }
        public string? FORBIDBUSINESS { get; set; }
        public string? FORBIDRETURN { get; set; }
        public string? INPUTMAN { get; set; }
        public DateTime CREDATE { get; set; }
        public string? CONTACTMAN { get; set; }
        public string? TELEPHONE { get; set; }
        public string? MOBILE { get; set; }
        public string? TYPE { get; set; }
        public int SEX { get; set; }
        public string? BIOSSALERNAME { get; set; }
        public string? CONSIGNEE { get; set; }
        public string? CONSIGNEETELEPHONE { get; set; }
        public string? RECEIVINGADDRESS { get; set; }
        public string? TOADDRESS { get; set; }
        public string? SETTLETYPE { get; set; }
        public string? SALERMASTERNAME { get; set; }
        public string? TRANSLINENAME { get; set; }
        public string? PLACETYPE { get; set; }
        public string? MERMECDEPTNAME { get; set; }
        public string? ENABLESTATUS { get; set; }
        public string? ACCOPENSALERNAME { get; set; }
        public DateTime SYS_MODIFYDATE { get; set; }
        public string? ISWRITEOFFFLAG { get; set; }
        public string? ADD_LXRBS { get; set; }
        public string? ADD_QF_KHFL { get; set; }
    }
}
