using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class pdhz:DataInfor,Interface.pdhz
    {
        public string djbh { get; set; }
        public string djbs { get; set; }
        public string rq { get; set; }
        public string pdbz { get; set; }
        public string yishj { get; set; }
        public string kaiprq { get; set; }
        public string ontime { get; set; }
        public string piaohao { get; set; }
        public string hw { get; set; }
        public string bm { get; set; }
        public string ywy { get; set; }
        public string username { get; set; }
        public string shenchr { get; set; }
        public string shenhr { get; set; }
        public string shenhrq { get; set; }
        public string shenhyj { get; set; }
        public string yanshr { get; set; }
        public string yansrq { get; set; }
        public decimal psje { get; set; }
        public string bendian { get; set; }
        public string jwh { get; set; }
        public string filterbs { get; set; }
        public string ywbmid { get; set; }
        public string ywyid { get; set; }
        public string beizhu { get; set; }
        public string lastmodifytime { get; set; }

        public static List<pdhz> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,djbs,rq,a.pdbz,yishj,kaiprq,ontime,piaohao,a.hw,bm,ywy,username,shenchr,shenhr,shenhrq,shenhyj,
yanshr,yansrq,sum(b.psje) as psje,bendian,a.jwh,filterbs,ywbmid,ywyid,a.beizhu,a.lastmodifytime  
from pdhz a
join pdmx b on a.djbh=b.djbh 
join sphwph c on b.spid=c.spid and b.pihao=c.pihao and a.hw=c.hw 
where c.is_fp = '是' and a.lastmodifytime > @lastmodifytime
group by a.djbh,djbs,rq,a.pdbz,yishj,kaiprq,ontime,piaohao,a.hw,bm,ywy,username,shenchr,shenhr,shenhrq,shenhyj,yanshr,yansrq,
a.psje,bendian,a.jwh,filterbs,ywbmid,ywyid,a.beizhu,a.lastmodifytime ";
                return conn.Query<pdhz>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
