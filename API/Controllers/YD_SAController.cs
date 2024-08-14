using API.YK;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YD_SAController : ControllerBase
    {
        [HttpPost]
        public IResult DOC([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_SADOC_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult DTL([FromHeader] string APIKey, [FromQuery] int salesid, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var list = YK.YD_SADTL_V.get_list(salesid, and);
                return Results.Ok(list);
            }
            catch (Exception ex) {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult DTLQRY([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_SADTLQRY_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

            [HttpPost]
        public object DTLQRY_SUM([FromHeader] string APIKey, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var data = YK.YD_SADTLQRY_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        public IResult UnrecSadtlqry([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_UNREC_SADTLQRY_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public object UnrecSadtlqry_sum([FromHeader] string APIKey, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var data = YK.YD_UNREC_SADTLQRY_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

        }

    }
}
