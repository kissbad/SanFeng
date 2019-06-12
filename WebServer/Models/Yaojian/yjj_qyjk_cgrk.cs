using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.Yaojian
{
    public class yjj_qyjk_cgrk
    {
        public string djbh { get; set; }
        public string rqrq { get; set; }
        public string ghqy { get; set; }
        public string xsdh { get; set; }
        public string yssb { get; set; }
        public DateTime yskssj { get; set; }
        public DateTime ysjssj { get; set; }
        public string clr { get; set; }
        public string ysjl { get; set; }
        public List<djmx> tm { get; set; }
        public class djmx
        {
            internal string djbh { get; set; }
            public string bwm { get; set; }
            public string bzgg { get; set; }
            public string scph { get; set; }
            public string scrq { get; set; }
            public string yxqz { get; set; }
            public int sl { get; set; }
        }

        public static List<yjj_qyjk_cgrk> GetData(string start_rq, string end_rq)
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                var hz = conn.Query<yjj_qyjk_cgrk>("wqh_yaojian_cgrk", new { type = "hz", start_rq, end_rq }, null, true, null, CommandType.StoredProcedure).ToList();
                var mx = conn.Query<djmx>("wqh_yaojian_cgrk", new { type = "mx", start_rq, end_rq }, null, true, null, CommandType.StoredProcedure).ToList();
                foreach (var i in hz) {
                    var x = from a in mx where a.djbh == i.djbh select a;
                    i.tm = x.ToList();
                }
                return hz;
            }
        }
    }
}