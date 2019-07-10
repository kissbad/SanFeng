using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class spkfk : DataInfor
    {
        public string spid { get; set; }
        public string spbh { get; set; }
        public string spmch { get; set; }
        public string sptm { get; set; }
        public string zjm { get; set; }
        public string beactive { get; set; }
        public string dw { get; set; }
        public string shpchd { get; set; }
        public string shpgg { get; set; }
        public string shengccj { get; set; }
        public string pizhwh { get; set; }
        public string jlgg { get; set; }
        public string imageUrl { get; set; }
        public string kcshl { get; set; }
        public string shlv { get; set; }

        public static spkfk get_sp(string spid) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from spkfk(nolock) where spid = @spid";
                return conn.QueryFirstOrDefault<spkfk>(sql,new { spid });
            }
        }

        public static List<spkfk> search(string pro_name,object p)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                //var sql = @"WX_sp_search";
                return conn.Query<spkfk>(pro_name, p, null, true, null, CommandType.StoredProcedure).ToList();
            }
        }

        public static void update_imageUrl(string spid, string imageUrl)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"update a set a.imageUrl = @imageUrl from spkfk a where a.spid = @spid";
                if (conn.Execute(sql, new { spid, imageUrl }) < 0)
                {
                    throw new Exception("imageUrl修改失败！");
                }
            }
        }
    }
}