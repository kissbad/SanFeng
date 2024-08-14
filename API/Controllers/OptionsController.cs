using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        [HttpPost]
        public IEnumerable<YK.YD_DDL_V> Post([FromQuery] int sysid)
        {
            return YK.YD_DDL_V.get_yd_ddl_v(sysid);
        }
    }
}
