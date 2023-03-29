using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using Dapper;
using WebServer.Models.KSOA;

namespace WebServer.Models.ZhiLian
{
    public class wqh_yl_cg
    {
        public string po_id { get; set; }
        public string po_no { get; set; }
        public string po_time { get; set; }
        public string enterprise_inner_code { get; set; }
        public string enterprise_name { get; set; }
        public string po_batch_no { get; set; }
        public decimal po_quantity { get; set; }
        public string po_product_time { get; set; }
        public string po_effective_time { get; set; }
        public decimal po_price { get; set; }
        public string goods_in_sn { get; set; }
        public string goods_name { get; set; }
        public string po_license { get; set; }
        public string po_specifications { get; set; }
        public string po_unit { get; set; }
        public string po_manufacturer { get; set; }
        public string po_source { get; set; }

        public static List<wqh_yl_cg> GetData(string rq)
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                var sql = @"select * from wqh_yl_cg where po_time >= @rq";
                return conn.Query<wqh_yl_cg>(sql, new { rq }).ToList();
            }
        }
    }
}