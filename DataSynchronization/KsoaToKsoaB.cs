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
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步spkfk↓↓↓↓↓", 1);
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
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步spkfk结束↑↑↑↑↑", 1);
        }

        public static void mchk(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步mchk↓↓↓↓↓", 1);
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
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步mchk结束↑↑↑↑↑", 1);
        }


        public static void sjjh_jh_rkhz(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_jh_rkhz↓↓↓↓↓", 1);
            var data = KSOA.jh_rkhz.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_jh_rkhz.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_jh_rkhz结束↑↑↑↑↑", 1);
        }

        public static void sjjh_jh_rkmx(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_jh_rkmx↓↓↓↓↓", 1);
            var data = KSOA.jh_rkmx.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_jh_rkmx.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_jh_rkmx结束↑↑↑↑↑", 1);
        }

        public static void sjjh_pf_ckhz(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_pf_ckhz↓↓↓↓↓", 1);
            var data = KSOA.pf_ckhz.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_pf_ckhz.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_pf_ckhz结束↑↑↑↑↑", 1);
        }

        public static void sjjh_pf_ckmx(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_pf_ckmx↓↓↓↓↓", 1);
            var data = KSOA.pf_ckmx.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_pf_ckmx.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_pf_ckmx结束↑↑↑↑↑", 1);
        }

        public static void fapiaogl(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步fapiaogl↓↓↓↓↓", 1);
            var data = KSOA.fapiaogl.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.fapiaogl.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步fapiaogl结束↑↑↑↑↑", 1);
        }

        public static void fapiaodet(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步fapiaodet↓↓↓↓↓", 1);
            var data = KSOA.fapiaodet.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.fapiaodet.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步fapiaodet结束↑↑↑↑↑", 1);
        }

        public static void sjjh_pdhz(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_pdhz↓↓↓↓↓", 1);
            var data = KSOA.pdhz.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_pdhz.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_pdhz结束↑↑↑↑↑", 1);
        }

        public static void sjjh_pdmx(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_pdmx↓↓↓↓↓", 1);
            var data = KSOA.pdmx.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_pdmx.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_pdmx结束↑↑↑↑↑", 1);
        }

        public static void sjjh_shpbshz(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_shpbshz↓↓↓↓↓", 1);
            var data = KSOA.shpbshz.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_shpbshz.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_shpbshz结束↑↑↑↑↑", 1);
        }

        public static void sjjh_shpbsmx(string lastmodifytime)
        {
            WQH.system.IO.File.WriteLog("↓↓↓↓↓B开始同步sjjh_shpbsmx↓↓↓↓↓", 1);
            var data = KSOA.shpbsmx.getList(lastmodifytime);
            if (data.Count > 0)
            {
                WQH.system.IO.File.WriteLog(string.Format("最新数据{0}条", data.Count), 1);
                foreach (var i in data)
                {
                    try
                    {
                        KSOA_B.sjjh_shpbsmx.Save(i);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(i.djbh + "::" + e.Message, 1);
                    }
                }
            }
            WQH.system.IO.File.WriteLog("↑↑↑↑↑B同步sjjh_shpbsmx结束↑↑↑↑↑", 1);
        }
    }
}
