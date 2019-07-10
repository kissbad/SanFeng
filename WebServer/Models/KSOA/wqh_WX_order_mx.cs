using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class wqh_WX_order_mx
    {
        public string djbh { get; set; }
        public int dj_sn { get; set; }
        public string xgdjbh { get; set; } = "";
        public string spid { get; set; }
        public string dw { get; set; }
        public string pihao { get; set; }
        public string baozhiqi { get; set; }
        public string sxrq { get; set; }
        public int jlgg { get; set; }
        public string hw { get; set; }
        public int baozhshl { get; set; }
        public decimal lingsshl { get; set; }
        public decimal shl { get; set; }
        public decimal dj { get; set; }
        public decimal hshj { get; set; }
        public decimal koul { get; set; }
        public decimal je { get; set; }
        public decimal shlv { get; set; }
        public decimal she { get; set; }
        public decimal hsje { get; set; }
        public decimal chbdj { get; set; }
        public string zengp { get; set; } = "否";
        public string pici { get; set; } = "";
        public string beizhu { get; set; } = "";

        public bool Save(SqlConnection conn, SqlTransaction transaction)
        {
            var sql = @"insert into wqh_WX_order_mx(djbh,dj_sn,xgdjbh,spid,dw,pihao,baozhiqi,sxrq,jlgg,hw,baozhshl,lingsshl,
shl,dj,hshj,koul,je,shlv,she,hsje,chbdj,zengp,pici,beizhu)
values(@djbh,@dj_sn,@xgdjbh,@spid,@dw,@pihao,@baozhiqi,@sxrq,@jlgg,@hw,@baozhshl,@lingsshl,
@shl,@dj,@hshj,@koul,@je,@shlv,@she,@hsje,@chbdj,@zengp,@pici,@beizhu)";
            return conn.Execute(sql, this, transaction) > 0;
        }
    }
}