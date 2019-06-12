using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class hzfamx : DataInfor
    {
        private string hzcode { get; set; }
        public string hzflbh { get; set; }
        public string hzflchina { get; set; }
        public List<hzfamx> next { get; set; }

        public static List<hzfamx> Get_list(string hzcode)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from hzfamx(nolock) where hzcode = @hzcode ";
                return conn.Query<hzfamx>(sql, new { hzcode }).ToList();
            }
        }
    }
}