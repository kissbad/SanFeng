using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class hzfa : DataInfor
    {
        public string hzcode { get; set; }
        public string hzchina { get; set; }
        public string fjrule { get; set; }
        public string fieldname { get; set; }

        public static hzfa Get(string hzcode) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from hzfa(nolock) where hzcode = @hzcode ";
                return conn.QueryFirstOrDefault<hzfa>(sql, new { hzcode });
            }
        }
    }
}