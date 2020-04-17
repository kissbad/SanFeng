using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_shpbshz:DataInfor
    {
        public static void Save(Interface.shpbshz data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_shpbshz where djbh = @djbh";
                if (conn.QueryFirst<int>(sql, new { data.djbh }) > 0)
                {
                    string sql1 = @"update a set djbs = @djbs,rq = @rq,yishj = @yishj,djlx = @djlx,kaiprq = @kaiprq,ontime = @ontime,piaohao = @piaohao,
bm = @bm,ywy = @ywy,username = @username,hw = @hw,shenhr = @shenhr,shenhrq = @shenhrq,shenhyj = @shenhyj,yanshr = @yanshr,
yansrq = @yansrq,syje = @syje,beizhu = @beizhu,bendian = @bendian,Hjid = @Hjid,ywbmid = @ywbmid,ywyid = @ywyid,
leixin = @leixin,dwbh = @dwbh,xgdjbh = @xgdjbh,lastmodifytime = @lastmodifytime
from sjjh_shpbshz a
where djbh = @djbh";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_shpbshz(djbh,djbs,rq,yishj,djlx,kaiprq,ontime,piaohao,bm,ywy,username,hw,shenhr,shenhrq,
shenhyj,yanshr,yansrq,syje,beizhu,bendian,Hjid,ywbmid,ywyid,leixin,dwbh,xgdjbh,lastmodifytime)
values(@djbh,@djbs,@rq,@yishj,@djlx,@kaiprq,@ontime,@piaohao,@bm,@ywy,@username,@hw,@shenhr,@shenhrq,
@shenhyj,@yanshr,@yansrq,@syje,@beizhu,@bendian,@Hjid,@ywbmid,@ywyid,@leixin,@dwbh,@xgdjbh,@lastmodifytime)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
