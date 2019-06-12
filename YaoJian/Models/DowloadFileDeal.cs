using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace YaoJian.Models
{
    public class DowloadFileDeal
    {
        /// <summary>
        /// 文件标识
        /// </summary>
        public int fileId { get; set; }
        /// <summary>
        /// 处理状态
        /// </summary>
        public string dealStatus { get; set; }
        /// <summary>
        /// 处理结果代码
        /// </summary>
        public string dealResult { get; set; }
        /// <summary>
        /// 处理结果描述
        /// </summary>
        public string dealDesc { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public string dealTime { get; set; }
        /// <summary>
        /// 补充说明
        /// </summary>
        public string other { get; set; }

        public bool Save()
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"insert into wqh_yj_DowloadFileDeal(create_time,fileId,dealStatus,dealResult,dealDesc,dealTime,other)
values(getdate(),@fileId,@dealStatus,@dealResult,@dealDesc,@dealTime,@other);
update a set a.upload_state = case when @dealStatus = '1' then '已经处理' else '未处理' end,
dealResult = @dealResult
from wqh_yj_UploadFileLog a 
where fid = @fileId";
                return conn.Execute(sql, this) > 0;
            }
        }

        public static List<DowloadFileDeal> get_List(string fileId)
        {
            using (SqlConnection conn = new SqlConnection(Global.KSOA_ConnectionString))
            {
                string sql = @"select * from wqh_yj_DowloadFileDeal where fileId = @fileId order by create_time desc";
                return conn.Query<DowloadFileDeal>(sql, new { fileId }).ToList();
            }
        }
    }
}