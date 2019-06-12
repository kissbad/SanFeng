using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class sphwph:DataInfor
    {
        public string spid { get; set; }
        public string hw { get; set; }
        public string huowname { get; set; }
        public string pihao { get; set; }
        public string baozhiqi { get; set; }
        public string sxrq { get; set; }
        public int shl { get; set; }
        public decimal gebjj { get; set; }
        public decimal chbje { get; set; }
        public string jwh { get; set; }
        public string is_fp { get; set; }
        public string deywy { get; set; }
        public string deywybm { get; set; }

        public static List<sphwph> get_spph(object p) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"wqh_WX_spph";
                return conn.Query<sphwph>(sql, p,null,true,null,System.Data.CommandType.StoredProcedure).AsList();
            }
        }
    }
}