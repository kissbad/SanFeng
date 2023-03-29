using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServer.Models.Request;
using WebServer.Models.ZhiLian;

namespace WebServer.Controllers
{
    public class ZhiLianController : ApiController
    {
        /// <summary>
        /// 东北制药数据直连
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public object DBZY(P_DBZY p)
        {
            try
            {
                var data = wqh_yl_cg.GetData(p.update_date);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
    }
}
