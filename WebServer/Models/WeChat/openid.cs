using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace WebServer.Models.WeChat
{
    public class openid
    {
        public string value { get; set; }
        public string session_key { get; set; }
        public openid(string appid, string code)
        {
            string url = string.Format(@"https://api.weixin.qq.com/sns/jscode2session?appid={0}&secret={1}&js_code={2}&grant_type=authorization_code",
                appid, "7c6170cc8edef5b89df49c418b42aa01", code);

            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string resp = response.Content.ReadAsStringAsync().Result;
                resp r = JObject.Parse(resp).ToObject<resp>();
                value = r.openid;
                session_key = r.session_key;
            }
            else
            {
                throw new Exception("网络错误" + response.StatusCode.ToString());
            }
        }

        private class resp {
            public string openid { get; set; }
            public string session_key { get; set; }
        }
    }
}