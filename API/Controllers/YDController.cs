using API.YK;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class YDController : ControllerBase
    {
        [HttpPost]
        public IResult EMPLOYEE_AP([FromHeader] string APIKey, [FromQuery] string USERID, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = YK.YD_EMPLOYEE_AP_V.get_list(USERID, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 获取供应商信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="and"></param>
        /// <returns></returns>
        [HttpPost]
        public IResult Supplyer([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_SUPPLYER_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 获取客户信息
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="and"></param>
        /// <returns></returns>
        [HttpPost]
        public IResult Customer([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_CUSTOMER_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 单位联系人
        /// </summary>
        /// <param name="and"></param>
        /// <returns></returns>
        [HttpPost]
        public IResult CompanyContact([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_COMPANY_TO_CONTACT_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 单位委托人
        /// </summary>
        /// <param name="and"></param>
        /// <returns></returns>
        [HttpPost]
        public IResult CompanyAgent([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_COMPANY_TO_AGENT_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// 单位证照
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="and"></param>
        /// <returns></returns>
        [HttpPost]
        public IResult CompanyLicense([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_COMPANY_LICENSE_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

        }
        /// <summary>
        /// 单位发票
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="and"></param>
        /// <returns></returns>
        [HttpPost]
        public IResult InvInfo([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_INV_INFO_V> (pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_QTYLST_V([FromHeader] string APIKey, [FromQuery] int pageIndex, [FromQuery] int pageSize, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var list = Common.GetList<YD_QTYLST_V>(pageIndex, pageSize, and);
                return Results.Ok(list);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IResult YD_QTYLST_V_SUM([FromHeader] string APIKey, [FromQuery] string and = "")
        {
            try
            {
                Com.IP_record(Request.HttpContext);
                Common.Check_APIKey(APIKey);
                var data = YK.YD_QTYLST_V.get_sum(and);
                return Results.Ok(data);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex.Message);
            }

        }
    }
}
