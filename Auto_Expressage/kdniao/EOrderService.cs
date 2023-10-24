using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Expressage.kdniao
{
    public class EOrderService
    {
        static readonly string EBusinessID = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["EBusinessID"]?.Value;
        static readonly string API_key = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["API_key"]?.Value;
        static readonly HttpClient client = new HttpClient();
        public static async Task EOrder(RequestData data)
        {
            string url = "https://api.kdniao.com/api/EOrderService";

            string json = JsonConvert.SerializeObject(data);

            //WQH.system.IO.File.WriteLog("提交数据:" + json, 1);

            HttpContent content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("RequestData", json),
                new KeyValuePair<string, string>("EBusinessID", EBusinessID),
                new KeyValuePair<string, string>("RequestType", "1007"),
                new KeyValuePair<string, string>("DataSign", DataSign.Encrypt(json,API_key,"UTF-8"))
            });

            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            HttpResponseMessage response = await client.PostAsync(url, content);

            string respContent = await response.Content.ReadAsStringAsync();
            WQH.system.IO.File.WriteLog(respContent, 1);

            ResponseData responseData = JsonConvert.DeserializeObject<ResponseData>(respContent);
            if (responseData.Success & responseData.ResultCode == "100")
            {
                responseData.SaveOrder(data.OrderCode);
                if (data.ShipperCode != "SF") { responseData.SaveOrder_2(data.OrderCode); }
                responseData.UpdateOrder(data.OrderCode);
            }
            else {
                if (responseData.ResultCode == "106") { responseData.UpdateOrder(data.OrderCode); }
                responseData.error(data.OrderCode);
            }
        }
    }
}
