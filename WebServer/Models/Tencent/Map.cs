using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebServer.Models.Tencent
{
    public class Map
    {
        string Key = "3FXBZ-SW73X-ZGN43-ZNJ6U-EI266-5KBQC";
        public class Location
        {
            /// <summary>
            /// 纬度
            /// </summary>
            public string Latitude { get; set; }
            /// <summary>
            /// 经度
            /// </summary>
            public string Longitude { get; set; }

            private string value;
            public string Value { get { return value; } set { value = Latitude + "," + Longitude; } }
        }
        /// <summary>
        /// 导航
        /// </summary>
        /// <returns></returns>
        public object Direction(Location start, Location end)
        {
            string url = string.Format(@"https://apis.map.qq.com/ws/direction/v1/driving/?from={0}&to={1}&output=json&callback=cb&key={2}",start.Value,end.Value, Key);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(url).Result;

            return null;
        }
    }
}