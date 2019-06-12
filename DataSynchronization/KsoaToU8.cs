using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSynchronization
{
    class KsoaToU8
    {
        public static void mchk(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓开始同步单位资料↓↓↓↓↓", 1);
            var mchks = KSOA.mchk.getList(lastmodifytime);
            if (mchks.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", mchks.Count), 1);
                foreach (var i in mchks)
                {
                    try
                    {
                        if (i.isxs == "是")
                        {
                            U8.Customer customer = new U8.Customer();
                            customer.cCusCode = i.danwbh;
                            customer.cCusName = customer.cCusAbbName = i.dwmch;
                            customer.cCCCode = i.danwbh.Contains("G") ? "X1" : i.danwbh.Substring(0, 2);
                            customer.Save();
                        }
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.danwbh  + "::" + e.Message, 1);
                    }
                    try
                    {
                        if (i.isjh == "是")
                        {
                            U8.Vendor vendor = new U8.Vendor();
                            vendor.cVenCode = i.danwbh;
                            vendor.cVenName = vendor.cVenAbbName = i.dwmch;
                            vendor.cVCCode = i.danwbh.Contains("X") ? "G1" : i.danwbh.Substring(0, 2);
                            vendor.Save();
                        }
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.danwbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑同步单位数据结束↑↑↑↑↑", 1);
        }

        public static void dwdydz(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓开始同步单位联系人↓↓↓↓↓", 1);
            var dwdydzs = KSOA.dwdydz.getList(lastmodifytime);
            if (dwdydzs.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", dwdydzs.Count), 1);
                foreach (var i in dwdydzs)
                {
                    try
                    {
                        U8.fitemss97 f = new U8.fitemss97();
                        f.citemcode = f.citemname = i.dwlxr;
                        f.bclose = i.dangqzht == "使用中" ? 0 : 1;
                        f.Save();
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.shouhid + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑同步单位联系人结束↑↑↑↑↑", 1);
        }
    }
}
