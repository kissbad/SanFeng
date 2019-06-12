using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaoJian.Models
{
    class wqh_yj_ContactsBusiness
    {
        public string enterPriceName { get; set; }
        public string enterPriceType { get; set; }
        public string fullAddress { get; set; }
        public string district { get; set; }

        public bool save()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"insert into wqh_yj_ContactsBusiness(enterPriceName,enterPriceType,fullAddress,district)
values(@enterPriceName,@enterPriceType,@fullAddress,@district)";
                return conn.Execute(sql, this) > 0;
            }
        }

        public static bool clear()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"truncate table wqh_yj_ContactsBusiness";
                return conn.Execute(sql) > 0;
            }
        }
    }
}
