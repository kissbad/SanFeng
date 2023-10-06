using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Expressage.kdniao
{
    public class EOrderService
    {
        static readonly HttpClient client = new HttpClient();
        public static async Task EOrder(RequestData data)
        {
            string url = "https://api.kdniao.com/api/EOrderService";

            string json = JsonConvert.SerializeObject(data);

            HttpContent content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("RequestData", json),
                new KeyValuePair<string, string>("EBusinessID", "1724293"),
                new KeyValuePair<string, string>("RequestType", "1007"),
                new KeyValuePair<string, string>("DataSign", DataSign.Encrypt(json,"5e4b8727-5c86-47ae-bb02-dcb14c0dd3e5","UTF-8"))
            });

            content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var response = await client.PostAsync(url, content);
            
            string respContent = await response.Content.ReadAsStringAsync();
            WQH.system.IO.File.WriteLog(respContent, 1);

            ResponseData responseData = JsonConvert.DeserializeObject<ResponseData>(respContent);
            WQH.system.IO.File.WriteLog(responseData.PrintTemplate, 1);

        }
    }
}
