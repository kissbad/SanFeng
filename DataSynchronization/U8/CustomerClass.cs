using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization.U8
{
    /// <summary>
    /// 客户分类档案
    /// </summary>
    class CustomerClass
    {
        /// <summary>
        /// 客户分类编码
        /// </summary>
        string cCCCode { get; set; }
        /// <summary>
        /// 类别名称 
        /// </summary>
        string cCCName { get; set; }
        /// <summary>
        /// 编码级次
        /// </summary>
        string iCCGrade { get; set; }
        /// <summary>
        /// 是否末级
        /// </summary>
        string bCCEnd { get; set; }
    }
}
