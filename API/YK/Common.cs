using System.DirectoryServices.Protocols;

namespace API.YK
{
    public class Common
    {
        public static readonly string APIKey = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("APIKey")?.Value;
        public static List<T> GetList<T>(int pageIndex, int pageSize, string and)
        {
            string VName = typeof(T).Name;
            string sql = @"select * from (select ROWNUM as r,yd_view.* from " + VName + @" yd_view where rownum <= " + pageIndex + " * " + pageSize + " " + and + ")" +
" where r between (" + pageIndex + " - 1) * " + pageSize + " + 1 and  " + pageIndex + " * " + pageSize;

            var data = Oracle.ExecuteDataTable(sql);
            return WQH.Convert.TableToList<T>(data);
        }
        public static void Check_APIKey(string APIKey) {
            if (APIKey != Common.APIKey) {
                throw new Exception("验证失败！！");
            }
        }
    }
}
