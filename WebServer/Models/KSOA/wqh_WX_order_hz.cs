using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class wqh_WX_order_hz:DataInfor
    {
        public string djbh { get; set; }
        public string djbs { get; set; } = "WXD";
        public string djlx { get; set; } = "";
        public string rq { get; set; } = DateTime.Now.ToString("yyyy-MM-dd");
        public string ontime { get; set; } = DateTime.Now.ToString("HH:mm:ss");
        public string shenhe { get; set; } = "否";
        public string is_zx { get; set; } = "否";
        public string username { get; set; }
        public string ywy { get; set; }
        public string dwbh { get; set; }
        public string lxr { get; set; }
        public string dzhdh { get; set; }
        public string shouhr { get; set; }
        public string shouhrdh { get; set; }
        public string dwlxr { get; set; }
        public string lxrdh { get; set; }
        public string deywy { get; set; }
        public string deywybm { get; set; }
        public string is_fp { get; set; }
        public string quyufl { get; set; }
        public string jsfs { get; set; }
        public string kpy { get; set; }

        public bool Save(SqlConnection conn, SqlTransaction transaction) {
                var sql = @"insert into wqh_WX_order_hz(djbh,djbs,djlx,rq,ontime,shenhe,is_zx,username,ywy,dwbh,lxr,dzhdh,shouhr,shouhrdh,
dwlxr,lxrdh,deywy,deywybm,is_fp,quyufl,jsfs,kpy)
values(@djbh,@djbs,@djlx,@rq,@ontime,@shenhe,@is_zx,@username,@ywy,@dwbh,@lxr,@dzhdh,@shouhr,@shouhrdh,
@dwlxr,@lxrdh,@deywy,@deywybm,@is_fp,@quyufl,@jsfs,@kpy)";
                return conn.Execute(sql, this,transaction)>0;
        }
    }
}