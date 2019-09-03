using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaoJian.Models.BaiDu
{
    public class OCR
    {
        public static string APP_ID = "16996833";
        public static string API_KEY = "4ZIfZZdOQkYTgDYUxihGWuhy";
        public static string SECRET_KEY = "884e8siKSM5gOxiusIMBsSU58xkFPk7H";
        public static Results Recognition(string image_path)
        {
            var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

            var image = File.ReadAllBytes(image_path);
            return JObject.Parse(client.GeneralBasic(image).ToString()).ToObject<Results>();
        }

        public class Results
        {
            public int words_result_num { get; set; }
            public List<Words> words_result { get; set; }


        }
        public class Words
        {
            public string words { get; set; }
        }
    }
}
