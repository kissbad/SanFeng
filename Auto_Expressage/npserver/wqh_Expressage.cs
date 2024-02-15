using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Expressage.npserver
{
    public class wqh_Expressage
    {
        public string salesid { get; set; }
        public string customname { get; set; }
        public string countryname { get; set; }
        public string cityname { get; set; }
        public string provincename { get; set; }
        public string contactman { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string consignee { get; set; }
        public string consigneetelephone { get; set; }
        public string receivingaddress { get; set; }
        public string expressid { get; set; }
        public string expresscode { get; set; }
        public string expressname { get; set; }
        public string customername { get; set; }
        public string customerpwd { get; set; }
        public string monthcode { get; set; }
        public string sendsite { get; set; }
        public string sendstaff { get; set; }
        public int exptype { get; set; }
        public string INPUTMANNAME { get; set; }
        public string MOBILENO { get; set; }
        public string ADDRESS_S { get; set; }
        public string PROVINCENAME_S { get; set; }
        public string CITYNAME_S { get; set; }
        public string COUNTRYNAME_S { get; set; }
        public decimal zx_insure { get; set; }
        public int dbs { get; set; }
        public int transtype { get; set; }
        public static List<wqh_Expressage> getList()
        {
            string sql = @"select * from wqh_expressage where rownum <= 20";
            var sp = Oracle.ExecuteDataTable(sql);
            //WQH.system.IO.File.WriteLog("22222", 1);
            return WQH.Convert.TableToList<wqh_Expressage>(sp);
        }
    }
}
