using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class pdhz:DataInfor
    {
        public string djbh { get; set; }
        public string rq { get; set; }
        public string ontime { get; set; }
        public string hw { get; set; }
        public string huowname { get; set; }
        public string username { get; set; }
        public string beizhu { get; set; }

        public static List<pdhz> get_pd_list()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select a.djbh,a.rq,a.ontime,a.hw,b.huowname,a.username,beizhu
from pdhz a
join huoweizl b on a.hw = b.hw
where a.pdbz='否' or a.pdbz='盘'
order by a.djbh";
                return conn.Query<pdhz>(sql).ToList();
            }
        }
    }
}