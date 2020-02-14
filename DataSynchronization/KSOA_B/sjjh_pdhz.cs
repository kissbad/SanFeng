using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.KSOA_B
{
    class sjjh_pdhz:DataInfor
    {
        public static void Save(Interface.pdhz data)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"select count(1) from sjjh_pdhz where djbh = @djbh";
                if (conn.QueryFirst<int>(sql, new { data.djbh }) > 0)
                {
                    string sql1 = @"update a set djbs = @djbs,rq = @rq,pdbz = @pdbz,yishj = @yishj,kaiprq = @kaiprq,ontime = @ontime,
piaohao = @piaohao,hw = @hw,bm = @bm,ywy = @ywy,username = @username,shenchr = @shenchr,shenhr = @shenhr,shenhrq = @shenhrq,
shenhyj = @shenhyj,yanshr = @yanshr,yansrq = @yansrq,psje = @psje,bendian = @bendian,jwh = @jwh,filterbs = @filterbs,
ywbmid = @ywbmid,ywyid = @ywyid,beizhu = @beizhu,lastmodifytime = @lastmodifytime
from sjjh_pdhz a
where djbh = @djbh";
                    conn.Execute(sql1, data);
                }
                else
                {
                    string sql2 = @"insert into sjjh_pdhz(djbh,djbs,rq,pdbz,yishj,kaiprq,ontime,piaohao,hw,bm,ywy,username,shenchr,
shenhr,shenhrq,shenhyj,yanshr,yansrq,psje,bendian,jwh,filterbs,ywbmid,ywyid,beizhu,lastmodifytime)
values(@djbh,@djbs,@rq,@pdbz,@yishj,@kaiprq,@ontime,@piaohao,@hw,@bm,@ywy,@username,@shenchr,
@shenhr,@shenhrq,@shenhyj,@yanshr,@yansrq,@psje,@bendian,@jwh,@filterbs,@ywbmid,@ywyid,@beizhu,@lastmodifytime)";
                    conn.Execute(sql2, data);
                }
            }
        }
    }
}
