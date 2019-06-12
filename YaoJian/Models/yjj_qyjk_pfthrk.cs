using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace YaoJian.Models
{
    class yjj_qyjk_pfthrk : UplondMod
    {
        public bool is_check { get; set; }
        public string djbh { get; set; }
        public string rqrq { get; set; }
        public string thqy { get; set; }
        public string enterPriceName { get; set; }
        public string clr { get; set; }
        public string ysjl { get; set; }
        public List<djmx> tm { get; set; }
        public class djmx
        {
            public string djbh { get; set; }
            public string bwm { get; set; }
            public string medicineCodeNumber { get; set; }
            public string bzgg { get; set; }
            public string scph { get; set; }
            public string scrq { get; set; }
            public string yxqz { get; set; }
            public int sl { get; set; }
            public string yy { get; set; }
            public string xsdh { get; set; }
        }

        public static List<yjj_qyjk_pfthrk> GetData(string start_rq, string end_rq)
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                var hz = conn.Query<yjj_qyjk_pfthrk>("wqh_yaojian_pfthrk", new { type = "hz", start_rq, end_rq }, null, true, null, CommandType.StoredProcedure).ToList();
                var mx = conn.Query<djmx>("wqh_yaojian_pfthrk", new { type = "mx", start_rq, end_rq }, null, true, null, CommandType.StoredProcedure).ToList();
                foreach (var i in hz)
                {
                    var x = from a in mx where a.djbh == i.djbh select a;
                    i.tm = x.ToList();
                }
                return hz;
            }
        }

        public XmlElement GetXML(XmlDocument xml)
        {
            XmlElement dj = xml.CreateElement("dj");
            dj.SetAttribute("djbh", djbh);
            dj.SetAttribute("rqrq", rqrq);
            dj.SetAttribute("thqy", thqy);
            dj.SetAttribute("clr", clr);
            dj.SetAttribute("ysjl", ysjl);
            foreach (var i2 in tm)
            {
                XmlElement tm = xml.CreateElement("tm");
                tm.SetAttribute("bwm", i2.bwm);
                tm.SetAttribute("bzgg", i2.bzgg);
                tm.SetAttribute("scph", i2.scph);
                tm.SetAttribute("scrq", i2.scrq);
                tm.SetAttribute("yxqz", i2.yxqz);
                tm.SetAttribute("sl", i2.sl.ToString());
                tm.SetAttribute("yy", i2.yy);
                tm.SetAttribute("xsdh", i2.xsdh);
                dj.AppendChild(tm);
            }
            return dj;
        }
    }
}
