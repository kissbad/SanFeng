using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace YaoJian.Models
{
    public class ContactsBusiness
    {
        public string enterPriceName { get; set; }
        public string enterPriceType { get; set; }
        public string district { get; set; }
        public string fullAddress { get; set; }
        public string businessCodeNumber { get; set; }

        public bool save()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"insert into jk_ContactsBusiness(enterPriceName,enterPriceType,district,fullAddress,businessCodeNumber)
values(@enterPriceName,@enterPriceType,@district,@fullAddress,@businessCodeNumber)";
                return conn.Execute(sql, this) > 0;
            }
        }

        public static bool clear()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"truncate table jk_ContactsBusiness";
                return conn.Execute(sql) > 0;
            }
        }
    }
}