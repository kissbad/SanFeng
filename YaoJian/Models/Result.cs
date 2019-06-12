using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YaoJian.Models
{
    /// <summary>
    /// 通用数据格式
    /// </summary>
    public class Result<T>
    {
        /// <summary>
        /// 操作状态代码
        /// </summary>
        public int resultCode { get; set; }
        /// <summary>
        /// 操作状态描述
        /// </summary>
        public string resultText { get; set; }
        /// <summary>
        /// 返回结果
        /// </summary>
        public T data { get; set; }
    }
}