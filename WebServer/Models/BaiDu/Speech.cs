using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebServer.Models.BaiDu
{
    public class Speech
    {
        public static string APP_ID = "16148851";
        public static string API_KEY = "PK65zfHrRVvOGS3BA3TbLGzt";
        public static string SECRET_KEY = "9GtXtQQ7a9OZ2GTysoC7gccrh3bMhEvR";

        public static string Tts(string text,string new_id)
        {
            var client = new Baidu.Aip.Speech.Tts(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间
            // 可选参数
            var option = new Dictionary<string, object>(){
                { "spd", 5}, // 语速
                { "vol", 6}, // 音量
                { "per", 0}  // 发音人，4：情感度丫丫童声
            };
            var result = client.Synthesis(text, option);

            if (result.ErrorCode == 0)  // 或 result.Success
            {
                MemoryStream ms = new MemoryStream(result.Data);
                var oss = new TaoBao.OSS();
                var x = oss.Upload(ms, "Speech/"+ new_id + ".mp3").ToString();
                return x;
            }
            else
            {
                throw new Exception("语音合成失败！！");
            }
        }
    }
}