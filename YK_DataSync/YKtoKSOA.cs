using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WQH;

namespace YK_DataSync
{
    internal class YKtoKSOA
    {
        public static void spkfk(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓开始同步yk_spkfk↓↓↓↓↓", 1);
            var spkfk = YK.spkfk.getList(lastmodifytime);
            if (spkfk.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", spkfk.Count), 1);
                foreach (var i in spkfk)
                {
                    try
                    {
                        KSOA.yk_spkfk.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.spid + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑同步yk_spkfk结束↑↑↑↑↑", 1);
        }
    }
}
