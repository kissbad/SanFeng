using Oracle.ManagedDataAccess.Client;

namespace API.YK.ZhiLian
{
    public class wqh_zhilian_apikey
    {
        public string NAME { get; set; }
        public string APIKEY { get; set; }

        public static void Check_APIKey(string name, string APIKey)
        {
            string? sql = @"select * from wqh_zhilian_apikey where name = :name and APIKEY = :APIKEY";
            var date = Oracle.ExecuteDataTable(sql, [new OracleParameter("name", name), new OracleParameter("APIKey", APIKey)]);

            if (date.Rows.Count <= 0)
            {
                throw new Exception("APIKey验证失败！！");
            }
        }
    }
}
