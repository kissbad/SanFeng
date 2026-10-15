using Aliyun.OSS;
using Aliyun.OSS.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebServer.Models.TaoBao
{
    public class OSS
    {
        //public string url { get; set; } = "oss-cn-shanghai.aliyuncs.com";
        //public string url_internal { get; set; } = "oss-cn-shanghai-internal.aliyuncs.com";
        //public string accessKeyId { get; set; } = "******************";
        //public string accessKeySecret { get; set; } = "******************";
        //public string bucketName { get; set; } = "xdyzhibo";
        //public string domain { get; set; } = "http://oss.vertq.com/";
        public string url { get; set; } = "oss-cn-shenzhen.aliyuncs.com";
        public string url_internal { get; set; } = "oss-cn-shenzhen-internal.aliyuncs.com";
        public string accessKeyId { get; set; } = "******************";
        public string accessKeySecret { get; set; } = "******************";
        public string bucketName { get; set; } = "wuqinhuai01";
        public string domain { get; set; } = "http://wuqinhuai01.oss-cn-shenzhen.aliyuncs.com/";
        
        public object Upload(Stream s, string fileName)
        {
            var conf = new ClientConfiguration();
            conf.MaxErrorRetry = 3;  // 3次错误重试
            conf.ConnectionTimeout = 10000;  //10秒超时 -internal
            var host = WQH.Web.HTTP.URL.getRootPath();
            var oss_host = url;
            //if (host.IndexOf("localhost") > -1)
            //{
            //    oss_host = url_internal;
            //}
            OssClient oss = new OssClient(oss_host, accessKeyId, accessKeySecret, conf);
            var o = oss.PutObject(bucketName, fileName, s);
            if (o.HttpStatusCode == HttpStatusCode.OK)
            {
                return domain + fileName;
            }
            else
            {
                throw new Exception("上传失败");
            }
        }
    }
}