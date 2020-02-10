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
    class yjj_qyjk_bhg : UplondMod
    {
        public bool is_check { get; set; }
        public string djbh { get; set; }
        public string bwm { get; set; }
        public string bzgg { get; set; }
        public string scph { get; set; }
        public string scrq { get; set; }
        public string yxqz { get; set; }
        public int sl { get; set; }
        public string yy { get; set; }
        public string sfcl { get; set; }

        public XmlElement GetXML(XmlDocument xml)
        {
            XmlElement tm = xml.CreateElement("tm");
            tm.SetAttribute("bwm", bwm);
            tm.SetAttribute("bzgg", bzgg);
            tm.SetAttribute("scph", scph);
            tm.SetAttribute("scrq", scrq);
            tm.SetAttribute("yxqz", yxqz);
            tm.SetAttribute("sl", sl.ToString());
            tm.SetAttribute("yy", yy);
            tm.SetAttribute("sfcl", sfcl);
            return tm;
        }

        public static List<yjj_qyjk_bhg> GetData(string start_rq, string end_rq)
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                return conn.Query<yjj_qyjk_bhg>("wqh_yaojian_bhgyp", new { start_rq, end_rq }, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }
    }
}