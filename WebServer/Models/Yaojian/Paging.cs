using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServer.Models.Yaojian
{
    public class Paging<T>
    {
        public T data { get; set; }
        public long dataId { get; set; }
        public int pageCount { get; set; }
        public int total { get; set; }
    }
}