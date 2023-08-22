using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServer.Models.KSOA;

namespace WebServer.YK
{
    public class FP
    {
        public string sasettleid { get; set; }
        public string zx_fpdz { get; set; }

        public static List<FP> get_FP_url(string sasettleid)
        {
            string sql = @"SELECT distinct sasettleid,zx_fpdz FROM bms_sa_settle_dTL where sasettleid = :sasettleid";
            var fp = Oracle.ExecuteDataTable(sql, new OracleParameter[] { new OracleParameter("sasettleid", sasettleid) });
            return WQH.Convert.TableToList<FP>(fp);
        }
    }
}