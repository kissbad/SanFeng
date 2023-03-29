using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServer.Models.Request;

namespace WebServer.Controllers
{
    public class ZhiLianController : ApiController
    {
        /// <summary>
        /// 获取openid
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public object DBZY(P_DBZY p)
        {
            try
            {
                return new { error = 0, msg = "查询成功", data = "777777" };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
    }
}
