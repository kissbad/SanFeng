using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Web_zhilian.YK
{
    public class wqh_zl_user
    {
        public int USERID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string CG_VIEW { get; set; }
        public string KC_VIEW { get; set; }
        public string XS_VIEW { get; set; }

        public static void Authentication(string username, string password) {

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("账号或密码为空！");
            }

            password = WQH.PassWord.Encryptpassword(password);

            string sql = @"select * from wqh_zl_user where username = :username and password = :password";

            DataTable dt = Oracle.ExecuteDataTable(sql, [new OracleParameter("username", username),
                new OracleParameter("password", password)]);

            if (dt.Rows.Count == 0) throw new Exception("账号不存在或密码错误！");
        }
    }
}
