using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization
{
    class KsoaToKsoaB
    {
        public static void spkfk(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步商品资料↓↓↓↓↓", 1);
            var spkfk = KSOA.spkfk.getList(lastmodifytime);
            if (spkfk.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", spkfk.Count), 1);
                foreach (var i in spkfk)
                {
                    try
                    {
                        KSOA_B.spkfk.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.spid + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步商品数据结束↑↑↑↑↑", 1);
        }

        public static void mchk(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步单位资料↓↓↓↓↓", 1);
            var mchk = KSOA.mchk.getList(lastmodifytime);
            if (mchk.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", mchk.Count), 1);
                foreach (var i in mchk)
                {
                    try
                    {
                        KSOA_B.mchk.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.dwbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步单位数据结束↑↑↑↑↑", 1);
        }
    }
}
