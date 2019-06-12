using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class WX_index_sp:DataInfor
    {
        public string spid { get; set; }
        public string spbh { get; set; }
        public string sptm { get; set; }
        public string spmch { get; set; }
        public string zjm { get; set; }
        public string dw { get; set; }
        public string shpchd { get; set; }
        public string shpgg { get; set; }
        public string shengccj { get; set; }
        public string pizhwh { get; set; }
        public string imageUrl { get; set; }

        public static List<WX_index_sp> getList(object p) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"wx_index_spList";
                return conn.Query<WX_index_sp>(sql, p,null,true,null,CommandType.StoredProcedure).ToList();
            }
        }
    }
}