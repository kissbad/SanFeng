using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class zhiydoc : DataInfor, IToken
    {
        public string dzyid { get; set; }
        public string dzycode { get; set; }
        public string dzyname { get; set; }
        public string zjm { get; set; }
        public string kl { get; set; }
        public string lgnname { get; set; }
        public string shjbumen { get; set; }
        public string beactive { get; set; }
        public string issp { get; set; }
        public string is_sky { get; set; }
        public string is_czy { get; set; }
        public string is_ywy { get; set; }
        public string is_bhy { get; set; }

        public static zhiydoc Login(object p)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from zhiydoc where lgnname = @lgnname";
                return conn.QueryFirstOrDefault<zhiydoc>(sql, p);
            }
        }

        public static zhiydoc Get(Func<string, zhiydoc> func, string str)
        {
            var user = func(str);
            if (user == null)
            {
                throw new Exception("用户不存在！");
            }
            else
            {
                return user;
            }
        }


        public static zhiydoc from_dzyid(string dzyid)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select * from zhiydoc where dzyid = @dzyid";
                return conn.QueryFirstOrDefault<zhiydoc>(sql, new { dzyid });
            }
        }

        public static zhiydoc from_openid(string openid)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select a.* from zhiydoc a
join wqh_WX_openid_dzyid b on a.dzyid = b.dzyid 
where b.openid = @openid";
                return conn.QueryFirstOrDefault<zhiydoc>(sql, new { openid });
            }
        }

        public static bool Binding_account(string dzyid, string openid)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"delete wqh_WX_openid_dzyid where openid = @openid;
insert into wqh_WX_openid_dzyid(openid,dzyid)values(@openid,@dzyid)";
                return conn.Execute(sql, new { openid, dzyid }) > 0;
            }
        }

        public static List<zhiydoc> get_kpy()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select * from zhiydoc (nolock) where beactive='是' and is_ywy='是'";
                return conn.Query<zhiydoc>(sql).ToList();
            }
        }
    }
}