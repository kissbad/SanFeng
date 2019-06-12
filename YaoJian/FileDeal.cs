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
using System.Threading.Tasks;
using System.Windows.Forms;
using YaoJian.Models;

namespace YaoJian
{
    public partial class FileDeal : Form
    {
        public string fid { get; set; }
        public FileDeal(string fid, string upload_state)
        {
            this.fid = fid;
            if (upload_state == "未处理")
            {
                DowloadFileDeal();
            }
            InitializeComponent();
            Get_DowloadFileDeal();
        }

        public void DowloadFileDeal()
        {
            try
            {
                //string url = string.Format("https://219.135.157.154:8445/data/clientAccept/toDowloadFileDeal.do?fid={0}&resType=json", fid);
                string url = string.Format("https://qy.gdfda.gov.cn:8445/data/clientAccept/toDowloadFileDeal.do?fid={0}&resType=json", fid);

                HttpClientHandler handler = new HttpClientHandler();

                var cer = WQH.Web.HTTP.Certificate.GetCertificateFromStore(
                        System.Security.Cryptography.X509Certificates.StoreName.My,
                        System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser,
                        "广东三丰医药有限公司");

                if (cer == null)
                {
                    MessageBox.Show("无法获取证书");
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
                    Result<DowloadFileDeal> res = JObject.Parse(resp).ToObject<Result<DowloadFileDeal>>();

                    if (res.resultCode == 0)
                    {
                        if (!res.data.Save())
                        {
                            MessageBox.Show("返回数据保存失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show("查询失败");
                    }
                }
                else
                {
                    MessageBox.Show("请求失败");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }

        public void Get_DowloadFileDeal()
        {
            var data = YaoJian.Models.DowloadFileDeal.get_List(fid);
            this.dataGridView1.DataSource = data;
        }
    }
}
