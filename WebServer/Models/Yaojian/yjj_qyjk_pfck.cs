using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.Yaojian
{
    /// <summary>
    /// 批发出库
    /// </summary>
    public class yjj_qyjk_pfck
    {
        public string djbh { get; set; }
        public DateTime ckrq { get; set; }
        public string cgqy { get; set; }
        public string ysfs { get; set; }
        public DateTime yskssj { get; set; }
        public DateTime ysjssj { get; set; }
        public djmx tm { get; set; }
        public class djmx
        {
            public string bwm { get; set; }
            public string bzgg { get; set; }
            public string scph { get; set; }
            public DateTime scrq { get; set; }
            public DateTime yxqz { get; set; }
            public int sl { get; set; }
            public string bz { get; set; }
        }

        public static List<yjj_qyjk_pfck> GetData(string start_rq,string end_rq)
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"select * from ";
                return conn.Query<yjj_qyjk_pfck>(sql, new { start_rq, end_rq }).ToList();
            }
        }
    }
}