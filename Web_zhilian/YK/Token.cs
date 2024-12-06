using Oracle.ManagedDataAccess.Client;

namespace Web_zhilian.YK
{
    public class Token
    {
        public int userid { get; set; }
        public string? token { get; set; }
        public DateTime expire_time { get; set; }
        public DateTime create_time { get; set; }

        private static string GenerateToken(int user_id, string? pass_word, DateTime expire_time)
        {
            return WQH.String.CreateMD5Hash(user_id.ToString() + "|" + pass_word + "|" + expire_time.ToString());
        }

        public Token(IToken it, int expire)
        {
            userid = it.USERID;
            create_time = DateTime.Now;
            expire_time = create_time.AddMinutes(expire);
            token = GenerateToken(userid, it.PASSWORD, expire_time);

            var sql = @"delete wqh_token where userid = :userid;
insert into wqh_token(dzyid,token,expire_time,create_time)
values(:userid,:token,:expire_time,:create_time) ";

            int i = Oracle.ExecuteNonQuery(sql, [new OracleParameter("userid", userid),
                new OracleParameter("userid", userid),
                new OracleParameter("token", token),
                new OracleParameter("expire_time", expire_time),
                new OracleParameter("create_time", create_time)]);


            if (i < 1)
            {
                throw new Exception("token保存失败！");
            }
        }


        public static wqh_zl_user Verify_token(string token)
        {

            var sql = @"select * from wqh_token where token = :token ";
            var data = Oracle.ExecuteDataTable(sql, new OracleParameter("token", token));

            Token t = WQH.Convert.TableToEntity<Token>(data);

            if (t == null)
            {
                throw new Exception("token无效！");
            }
            else if (t.expire_time < DateTime.Now)
            {
                throw new Exception("token过期！");
            }

            var user = new wqh_zl_user(t.userid);
            if (t.token != GenerateToken(user.USERID, user.PASSWORD, t.expire_time))
            {
                throw new Exception("token检验失败");
            }
            else { return user; }

        }

    }
}
