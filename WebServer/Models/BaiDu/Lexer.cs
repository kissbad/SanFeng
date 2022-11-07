using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.BaiDu
{
    public class Lexer
    {
        public static string APP_ID = "24689337";
        public static string API_KEY = "jNET6qG3FCOOFtjQWY7YO6vU";
        public static string SECRET_KEY = "LRG0ufB4MlRCSWNctE7Hws7I1mVjjbhx";

        public static void dizhisb(string text)
        {
            var client = new Baidu.Aip.Nlp.Nlp(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

            var result = client.Lexer(text);
        }
    }
}