using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServer.Models.KSOA;
using WebServer.Models.Request;
using WebServer.YK;

namespace WebServer.Controllers
{
    public class YKController : ApiController
    {
        [HttpPost]
        public object XZ(string djbh)
        {
            try
            {
                var fp = FP.get_FP_url(djbh);
                return new { error = 0, msg = "查询成功", data = fp };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
    }
}