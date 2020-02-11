using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataSynchronization
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        Thread th = new Thread(ThreadAction);
        Thread th2 = new Thread(ThreadAction2);

        protected override void OnStart(string[] args)
        {
            WQH.system.IO.File.WriteLog("服务开始 ", 1);
            //开始线程
            th.IsBackground = true;
            th.Start();

            th2.IsBackground = true;
            th2.Start();
        }

        public static void ThreadAction()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var updatetime = config.AppSettings.Settings["UpdateTime"]?.Value;

                while (true)
                {
                    try
                    {
                        if (DateTime.Now.Minute.ToString() == (string.IsNullOrWhiteSpace(updatetime) ? "0" : updatetime))
                        {
                            var lastmodifytime = config.AppSettings.Settings["LastUpdateTime"].Value;
                            KsoaToU8.mchk(lastmodifytime);
                            //KsoaToU8.dwdydz(lastmodifytime);
                            //修改最后更新时间
                            config.AppSettings.Settings["LastUpdateTime"].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                            config.Save(ConfigurationSaveMode.Modified);
                        }

                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(e.Message, 1);
                    }
                    Thread.Sleep(60 * 1000);
                }
            }
            catch (Exception e)
            {
                WQH.system.IO.File.WriteLog(e.Message, 1);
            }
        }

        public static void ThreadAction2()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                while (true)
                {
                    try
                    {
                        var lastmodifytime = config.AppSettings.Settings["LastUpdateTime_b"].Value;
                        config.AppSettings.Settings["LastUpdateTime_b"].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        config.Save(ConfigurationSaveMode.Modified);

                        //KsoaToKsoaB.spkfk(lastmodifytime);
                        //KsoaToKsoaB.mchk(lastmodifytime);
                        //KsoaToKsoaB.sjjh_jh_rkhz(lastmodifytime);
                        //KsoaToKsoaB.sjjh_jh_rkmx(lastmodifytime);  
                        KsoaToKsoaB.sjjh_pf_ckhz(lastmodifytime);
                    }
                    catch (Exception e)
                    {
                        WQH.system.IO.File.WriteLog(e.Message, 1);
                    }
                    Thread.Sleep(5 * 60 * 1000);
                }
            }
            catch (Exception e)
            {
                WQH.system.IO.File.WriteLog(e.Message, 1);
            }
        }

        protected override void OnStop()
        {
            th.Abort();
            th2.Abort();
            WQH.system.IO.File.WriteLog("服务停止 ", 1);
        }
    }
}
