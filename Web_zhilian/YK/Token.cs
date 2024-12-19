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

        public Token() { }

        public Token(IToken it, int expire)
        {
            userid = it.USERID;
            create_time = DateTime.Now;
            expire_time = create_time.AddMinutes(expire);
            token = GenerateToken(userid, it.PASSWORD, expire_time);

            delete();
            Save();
        }

        private void delete() {
            string sql = @"delete wqh_token where userid = :userid";
            Oracle.ExecuteNonQuery(sql, new OracleParameter("userid", userid));
        }

        private void Save()
        {
            var sql = @"insert into wqh_token(userid,token,expire_time,create_time)values(:userid,:token,:expire_time,:create_time) ";

            int i = Oracle.ExecuteNonQuery(sql, [new OracleParameter("userid", userid),
                new OracleParameter("token", token),
                new OracleParameter("expire_time", expire_time),
                new OracleParameter("create_time", create_time)]);

            if (i < 1)
            {
                throw new Exception("token保存失败！");
            }
        }



        public static wqh_zhilian_user Verify_token(string token)
        {
            var sql = @"select * from wqh_token where token = :token ";
            var data = Oracle.ExecuteDataTable(sql, new OracleParameter("token", token));

            if (data.Rows.Count < 1)
            {
                throw new Exception("token无效！");
            }

            Token t = WQH.Convert.TableToEntity<Token>(data);
            
            if (t.expire_time < DateTime.Now)
            {
                throw new Exception("token过期！");
            }

            var user = wqh_zhilian_user.get_formid(t.userid);
            if (t.token != GenerateToken(user.USERID, user.PASSWORD, t.expire_time))
            {
                throw new Exception("token检验失败");
            }
            else { return user; }

        }

    }
}
