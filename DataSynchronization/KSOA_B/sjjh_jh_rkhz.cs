using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_jh_rkhz:DataInfor
    {
        public static void Save(Interface.jh_rkhz data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_jh_rkhz where djbh = @djbh";
                if (conn.QueryFirst<int>(sql, new { data.djbh }) > 0)
                {
                    string sql1 = @"update a set djbs = @djbs,djlx = @djlx,rq = @rq,ontime = @ontime,bm = @bm,dwbh = @dwbh,username = @username,
ywy = @ywy,bendian = @bendian,is_chonghong = @is_chonghong,dj_chonghong = @dj_chonghong,thfs = @thfs,
is_fp = @is_fp,deywy = @deywy,shjy = @shjy,shjy2 = @shjy2,shjy3 = @shjy3,lhdh = @lhdh,is_zx = @is_zx,
lastmodifytime = @lastmodifytime,gldjbh = @gldjbh
from sjjh_jh_rkhz a
where djbh = @djbh";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_jh_rkhz(djbh,djbs,djlx,rq,ontime,bm,dwbh,username,ywy,bendian,is_chonghong,
dj_chonghong,thfs,is_fp,deywy,shjy,shjy2,shjy3,lhdh,is_zx,lastmodifytime,gldjbh)
values(@djbh,@djbs,@djlx,@rq,@ontime,@bm,@dwbh,@username,@ywy,@bendian,@is_chonghong,
@dj_chonghong,@thfs,@is_fp,@deywy,@shjy,@shjy2,@shjy3,@lhdh,@is_zx,@lastmodifytime,@gldjbh)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
