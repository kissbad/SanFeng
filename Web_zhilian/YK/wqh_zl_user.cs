using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Web_zhilian.YK
{
    public class wqh_zl_user : IToken
    {
        public int USERID { get; set; }
        public string? USERNAME { get; set; }
        public string? PASSWORD { get; set; }
        public string? CG_VIEW { get; set; }
        public string? KC_VIEW { get; set; }
        public string? XS_VIEW { get; set; }

        public static string Authentication(string username, string password) {

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("账号或密码为空！");
            }

            string sql = @"select * from wqh_zl_user where username = :username";

            DataTable dt = Oracle.ExecuteDataTable(sql, [new OracleParameter("username", username)]);

            if (dt.Rows.Count == 0) throw new Exception("账号不存在！");

            var user = WQH.Convert.TableToEntity<wqh_zl_user>(dt);

            if (password != WQH.PassWord.Discryptpassword(user.PASSWORD)) throw new Exception("密码错误！");

            Token t = new Token(user, 30);

            return t.token;
        }

        public static wqh_zl_user get_formid(int userid) {
            string sql = @"select * from wqh_zl_user where userid = :userid ";

            DataTable dt = Oracle.ExecuteDataTable(sql, [new OracleParameter("userid", userid)]);

            return WQH.Convert.TableToEntity<wqh_zl_user>(dt);
        }
    }
}
