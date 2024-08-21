using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        /// <summary>
        /// 检索货品
        /// </summary>
        /// <param name="pageIndex">页数</param>
        /// <param name="pageSize">每页行数</param>
        /// <param name="keyword">检索关键字</param>
        /// <returns></returns>
        [HttpPost]
        public IEnumerable<YK.Goods> Post( [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string keyword="", [FromQuery] string and = "")
        {
            Com.IP_record(Request.HttpContext);
            return YK.Goods.get_goodslist(keyword, pageIndex, pageSize,and);
        }
    }
}
