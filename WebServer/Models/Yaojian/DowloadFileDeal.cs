using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Yaojian
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
    }
}