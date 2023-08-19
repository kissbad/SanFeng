using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace YK_DataSync
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        Thread th = new Thread(ThreadAction);

        protected override void OnStart(string[] args)
        {
            th.IsBackground = true;
            th.Start();
        }

        public static void ThreadAction()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        var lastmodifytime = config.AppSettings.Settings["LastUpdateTime"].Value;
                        config.AppSettings.Settings["LastUpdateTime"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        config = null;

                        Action<string> action = null;
                        action += YKtoKSOA.spkfk;
                        //action += KsoaToKsoaB.mchk;
                        //action += KsoaToKsoaB.sjjh_jh_rkhz;
                        //action += KsoaToKsoaB.sjjh_jh_rkmx;
                        //action += KsoaToKsoaB.sjjh_pf_ckhz;
                        //action += KsoaToKsoaB.sjjh_pf_ckmx;
                        //action += KsoaToKsoaB.fapiaogl;
                        //action += KsoaToKsoaB.fapiaodet;
                        //action += KsoaToKsoaB.sjjh_pdhz;
                        //action += KsoaToKsoaB.sjjh_pdmx;
                        //action += KsoaToKsoaB.sjjh_shpbshz;
                        //action += KsoaToKsoaB.sjjh_shpbsmx;

                        action(lastmodifytime);
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
        }
    }
}
