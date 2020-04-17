using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA
{
    class shpbshz:DataInfor,Interface.shpbshz
    {
        public string djbh { get; set; }
        public string djbs { get; set; }
        public string rq { get; set; }
        public string yishj { get; set; }
        public string djlx { get; set; }
        public string kaiprq { get; set; }
        public string ontime { get; set; }
        public string piaohao { get; set; }
        public string bm { get; set; }
        public string ywy { get; set; }
        public string username { get; set; }
        public string hw { get; set; }
        public string shenhr { get; set; }
        public string shenhrq { get; set; }
        public string shenhyj { get; set; }
        public string yanshr { get; set; }
        public string yansrq { get; set; }
        public decimal syje { get; set; }
        public string beizhu { get; set; }
        public string bendian { get; set; }
        public string Hjid { get; set; }
        public string ywbmid { get; set; }
        public string ywyid { get; set; }
        public string leixin { get; set; }
        public string dwbh { get; set; }
        public string xgdjbh { get; set; }
        public string lastmodifytime { get; set; }

        public static List<shpbshz> getList(string lastmodifytime)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.djbh,a.djbs,rq,yishj,djlx,kaiprq,ontime,piaohao,bm,ywy,username,a.hw,shenhr,shenhrq,shenhyj,yanshr,yansrq,
sum(b.syje) as syje,a.beizhu,bendian,a.Hjid,ywbmid,ywyid,leixin,dwbh,a.xgdjbh,a.lastmodifytime 
from shpbshz a
join shpbsmx b on a.djbh=b.djbh 
join sphwph c on b.spid=c.spid and b.pihao=c.pihao and a.hw=c.hw and c.is_fp='是'
where a.lastmodifytime  > @lastmodifytime 
group by a.djbh,a.djbs,rq,yishj,djlx,kaiprq,ontime,piaohao,bm,ywy,username,a.hw,shenhr,shenhrq,shenhyj,yanshr,yansrq,
a.syje,a.beizhu,bendian,a.Hjid,ywbmid,ywyid,leixin,dwbh,a.xgdjbh,a.lastmodifytime ";
                return conn.Query<shpbshz>(sql, new { lastmodifytime }).ToList();
            }
        }
    }
}
