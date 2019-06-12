using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace YaoJian.Models
{
    public class wqh_yj_UploadFileLog
    {
        public string id { get; set; }
        public DateTime upload_time { get; set; }
        public string upload_type { get; set; }
        public string upload_state { get; set; }
        public string fid { get; set; }
        public List<string> djbhs { get; set; }

        public bool Save()
        {
            if (djbhs == null||djbhs?.Count == 0)
            {
                throw new MyException("上传数据保存错误，单据列表无数据");
            }
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {

                id = Guid.NewGuid().ToString();
                upload_time = DateTime.Now;
                string sql = @"insert into wqh_yj_UploadFileLog(id,upload_time,upload_type,upload_state,fid)
values(@id,@upload_time,@upload_type,@upload_state,@fid)";
                int i = conn.Execute(sql, this);

                foreach (var djbh in djbhs)
                {
                    string sql2 = @"insert into wqh_yj_UploadFileDeal(fid,djbh)values(@fid,@djbh)";
                    i += conn.Execute(sql2, new { fid, djbh });
                }
                return i > djbhs.Count;
            }
        }

        public static List<wqh_yj_UploadFileLog> Get_data()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"select id,upload_time,upload_type,upload_state,fid 
from wqh_yj_UploadFileLog order by upload_time desc";
                return conn.Query<wqh_yj_UploadFileLog>(sql).ToList();
            }
        }

    }
}