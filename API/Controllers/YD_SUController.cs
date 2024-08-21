using API.YK;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YD_SUController : ControllerBase
    {
        [HttpPost]
        public IResult YD_SUCONDOC_V([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_SUCONDOC_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public object Sucondoc_sum([FromHeader] string APIKey, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var data = YK.YD_SUCONDOC_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        public IResult YD_SUCONDTL_V([FromHeader] string APIKey, [FromQuery] int SUCONID, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = YK.YD_SUCONDTL_V.get_list(SUCONID, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_UNREC_SUDTLQRY_V([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_UNREC_SUDTLQRY_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public object UnrecSudtlqry_sum([FromHeader] string APIKey, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var data = YK.YD_UNREC_SUDTLQRY_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        public IResult YD_SUDTLQRY_V([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_SUDTLQRY_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public object Sudtlqry_sum([FromHeader] string APIKey, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var data = YK.YD_SUDTLQRY_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
    }
}
