using Auto_Expressage.kdniao;
using Auto_Expressage.npserver;
using Newtonsoft.Json;
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

namespace Auto_Expressage
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
            WQH.system.IO.File.WriteLog("服务开始 ", 1);
            th.IsBackground = true;
            th.Start();
        }

        public static async void ThreadAction()
        {
            try
            {
                while (true)
                {

                    try
                    {
                        List<wqh_Expressage> exp_list = npserver.wqh_Expressage.getList();

                        //WQH.system.IO.File.WriteLog(exp_list.Count.ToString(), 1);

                        foreach (wqh_Expressage exp in exp_list) {
                            RequestData data = new RequestData(exp);
                            await EOrderService.EOrder(data);
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

        protected override void OnStop()
        {
            th.Abort();
            WQH.system.IO.File.WriteLog("服务停止 ", 1);
        }
    }
}
