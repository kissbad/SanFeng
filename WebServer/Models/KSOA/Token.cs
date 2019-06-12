using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class Token : DataInfor
    {
        public string dzyid { get; set; }
        public string token { get; set; }
        public DateTime expire_time { get; set; }
        public DateTime create_time { get; set; }

        private static string GenerateToken(string user_id, string pass_word, DateTime expire_time)
        {
            return WQH.String.CreateMD5Hash(user_id + "|" + pass_word + "|" + expire_time.ToString());
        }

        public Token() { }
        public Token(IToken it, int expire)
        {
            dzyid = it.dzyid;
            create_time = DateTime.Now;
            expire_time = create_time.AddMinutes(expire);
            token = GenerateToken(dzyid, it.kl, expire_time);
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"delete wqh_token where dzyid = @dzyid;
insert into wqh_token(dzyid,token,expire_time,create_time)
values(@dzyid,@token,@expire_time,@create_time) ";
                if (conn.Execute(sql, this) < 1)
                {
                    throw new Exception("token保存失败！");
                }
            }
        }

        public static zhiydoc Verify_token(string token)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from wqh_token where token = @token ";
                var t = conn.QueryFirstOrDefault<Token>(sql, new { token });
                if (t == null)
                {
                    throw new Exception("token无效！");
                }
                else if (t.expire_time < DateTime.Now)
                {
                    throw new Exception("token过期！");
                }

                var user = zhiydoc.Get(zhiydoc.from_dzyid, t.dzyid);
                if (t.token != GenerateToken(user.dzyid, user.kl, t.expire_time))
                {
                    throw new Exception("token检验失败");
                }
                else { return user; }
                
            }
        }
    }
}