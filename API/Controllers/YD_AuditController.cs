using API.YK;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YD_AuditController : ControllerBase
    {
        [HttpPost]
        public IResult YD_INSTANCE_WAIT_V([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_INSTANCE_WAIT_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_INSTANCE_WAIT_V_count([FromHeader] string APIKey,  [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var data = YK.YD_INSTANCE_WAIT_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_INSTANCE([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_INSTANCE>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_INSTANCE_insert([FromHeader] string APIKey, [FromBody] YD_INSTANCE data)
        {
            try
            {
                Common.Check_APIKey(APIKey);
                data.insert();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_INSTANCE_delete([FromHeader] string APIKey, [FromQuery] int instdtlid)
        {
            try
            {
                Common.Check_APIKey(APIKey);
                YK.YD_INSTANCE.delete(instdtlid);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_INSTANCE_update([FromHeader] string APIKey, [FromBody] YD_INSTANCE data)
        {
            try
            {
                Common.Check_APIKey(APIKey);
                data.update();
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
    }
}
