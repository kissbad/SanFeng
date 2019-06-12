using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YaoJian.Models;

namespace YaoJian
{
    public partial class UpdateContactsBusiness : Form
    {
        public UpdateContactsBusiness()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(DownloadContactsBusiness);
            t.Start();
            Closed += (x, y) => { t.Abort(); };
        }

        private void ShowLog(string msee)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action<string>(ShowLog), msee);
            }
            else
            {
                textBox1.Text += string.Format("{0}\r\n", msee);
                textBox1.Focus();
                textBox1.Select(textBox1.TextLength, 0);
                textBox1.ScrollToCaret();
            }
        }

        private void enabled(Control sender, bool abled)
        {
            if (sender.InvokeRequired)
            {
                sender.Invoke(new Action<Control, bool>(enabled), sender, abled);
            }
            else
            {
                sender.Enabled = abled;
            }
        }

        private void DownloadContactsBusiness()
        {
            try
            {
                enabled(button1, false);
                ShowLog("开始更新");
                long dataId = 0;
                int pageCount = 0;
                int total = 0;
                while (total >= pageCount)
                {
                    //string url = string.Format("https://219.135.157.154:8445/data/clientAccept/toContactsBusiness.do?dataId={0}&resType=json", dataId);
                    string url = string.Format("https://qy.gdfda.gov.cn:8445/data/clientAccept/toContactsBusiness.do?dataId={0}&resType=json", dataId);

                    HttpClientHandler handler = new HttpClientHandler();

                    var cer = WQH.Web.HTTP.Certificate.GetCertificateFromStore(
                        System.Security.Cryptography.X509Certificates.StoreName.My,
                        System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser,
                        "广东三丰医药有限公司");
                    if (cer == null) {
                        ShowLog("无法获取证书！！");
                        enabled(button1, true);
                        return;
                    }

                    handler.ClientCertificates.Add(cer);
                    HttpClient client = new HttpClient(handler);
                    client.MaxResponseContentBufferSize = 256000;
                    client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string resp = response.Content.ReadAsStringAsync().Result;

                        JObject jo = JObject.Parse(resp);
                        Result<Paging<List<wqh_yj_ContactsBusiness>>> result = jo.ToObject<Result<Paging<List<wqh_yj_ContactsBusiness>>>>();
                        if (result.resultCode == 0)
                        {
                            if (dataId == 0) { wqh_yj_ContactsBusiness.clear(); }
                            dataId = result.data.dataId;
                            pageCount = result.data.pageCount;
                            total = result.data.total;
                            List<wqh_yj_ContactsBusiness> list = result.data.data;

                            foreach (var i in list)
                            {
                                i.save();
                            }
                            ShowLog("存入数据" + total.ToString());
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        ShowLog("连接错误：" + response.StatusCode);
                    }
                }
                ShowLog("更新完成");
                enabled(button1, true);
            }
            catch (Exception ex)
            {
                ShowLog(ex.Message + ex.StackTrace);
                enabled(button1, true);
            }
        }
    }
}
