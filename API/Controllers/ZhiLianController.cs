using API.YK;
using API.YK.ZhiLian;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ZhiLianController : ControllerBase
    {
        [HttpPost]
        public IResult BX_CG([FromQuery] string APIKey, [FromQuery] DateTime startdate)
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                wqh_zhilian_apikey.Check_APIKey("BX", APIKey);
                var list = YK.ZhiLian.wqh_bx_cg.get_list(startdate);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult BX_KC([FromQuery] string APIKey)
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                wqh_zhilian_apikey.Check_APIKey("BX", APIKey);
                var list = YK.ZhiLian.wqh_bx_kc.get_list();
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult BX_XS([FromQuery] string APIKey, [FromQuery] DateTime startdate)
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                wqh_zhilian_apikey.Check_APIKey("BX", APIKey);
                var list = YK.ZhiLian.wqh_bx_xsh.get_list(startdate);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
    }
}
