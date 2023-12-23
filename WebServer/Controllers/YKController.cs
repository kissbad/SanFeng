using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Razor.Tokenizer.Symbols;
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
        [HttpPost]
        public object get_splist(string keyword)
        {
            try {
                var sp_list = YK.wqh_sp.get_splist(keyword);
                return new { error = 0, msg = "查询成功", data = sp_list };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        [HttpPost]
        public object update_barcode(int goodsid, string barcode)
        {
            try
            {
                wqh_sp.update_barcode(goodsid, barcode);
                return new { error = 0, msg = "修改成功"};
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        }
}