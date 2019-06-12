using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.Yaojian
{
    public class wqh_yj_UploadFileLog
    {
        public string id { get; set; }
        public DateTime upload_time { get; set; }
        public string upload_type { get; set; }
        public string upload_state { get; set; }
        public string fid { get; set; }

        public bool Save() {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                id = Guid.NewGuid().ToString();
                upload_time = DateTime.Now;
                string sql = @"insert into wqh_yj_UploadFileLog(id,upload_time,upload_type,upload_state,fid)
values(@id,@upload_time,@upload_type,@upload_state,@fid)";
                return conn.Execute(sql, this) > 0;
            }
        }
    }
}