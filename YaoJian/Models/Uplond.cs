using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace YaoJian.Models
{
    class Uplond
    {
        public string xml_name { get; set; }
        public string xml_Validate { get; set; }
        public string upload_type { get; set; }

        public async Task<bool> doUplond(XmlDocument xml, List<string> djbhs)
        {
            string xml_v = WQH.Xml.Validate.XmlValidationByXsd(xml.InnerXml, Global.BasePath + "/XSD/" + xml_Validate);

            
            if (!string.IsNullOrWhiteSpace(xml_v))
            {
                throw new Exception(xml_v);
            }

            //string url = "https://219.135.157.154:8445/data/clientAccept/toUploadFile.do";
            string url = "https://qy.gdfda.gov.cn:8445/data/clientAccept/toUploadFile.do";

            MultipartFormDataContent mfdc = new MultipartFormDataContent();
            mfdc.Add(new StringContent(xml.InnerXml), "signFile", xml_name);
            mfdc.Add(new StringContent("json"), "resType");

            X509Certificate2 x509 = WQH.Web.HTTP.Certificate.GetCertificateFromFriendlyName(
                    System.Security.Cryptography.X509Certificates.StoreName.My,
                    System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser,
                    Global.Certificate_name);


            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificates.Add(x509);

            HttpClient client = new HttpClient(handler);
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");


            HttpResponseMessage response = await client.PostAsync(url, mfdc);

            //HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string resp = response.Content.ReadAsStringAsync().Result;
                Result<string> res = JObject.Parse(resp).ToObject<Result<string>>();

                if (res.resultCode == 0)
                {
                    wqh_yj_UploadFileLog ulfl = new wqh_yj_UploadFileLog();
                    ulfl.upload_type = upload_type;
                    ulfl.upload_state = "未处理";
                    ulfl.fid = res.data;
                    ulfl.djbhs = djbhs;
                    if (ulfl.Save())
                    {
                        return true;
                    }
                    else
                    {
                        throw new MyException("数据保存失败");
                    }
                }
                else
                {
                    throw new MyException("上传失败" + res.resultCode + res.resultText);
                }
            }
            else
            {
                throw new MyException("网络错误:" + response.StatusCode.ToString());
            }
        }

        public XmlDocument GetXml<T>(List<T> mods)
        {
            XmlDocument xml = new XmlDocument();
            xml.PreserveWhitespace = false;
            XmlElement Object = xml.CreateElement("Object");
            Object.SetAttribute("Id", "DataObjectId");

            XmlElement x;

            if (typeof(T) == typeof(yjj_qyjk_bhg))
            {
                XmlElement dj = xml.CreateElement("dj");
                dj.SetAttribute("xmlns", "http://cmsland.com/" + xml_Validate);
                Object.AppendChild(dj);
                x = dj;
            }
            else
            {
                XmlElement jh = xml.CreateElement("jh");
                jh.SetAttribute("xmlns", "http://cmsland.com/" + xml_Validate);
                Object.AppendChild(jh);
                x = jh;
            }

            foreach (var i in mods)
            {
                x.AppendChild((i as UplondMod).GetXML(xml));
            }

            xml.AppendChild(Object);

            var cer = WQH.Web.HTTP.Certificate.GetCertificateFromFriendlyName(
                    System.Security.Cryptography.X509Certificates.StoreName.My,
                    System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser,
                    Global.Certificate_name);

            if (cer == null)
            {
                throw new MyException("获取证书失败！！");
            }

            CspParameters cp = new CspParameters();
            cp.KeyContainerName = "MyKeyContainerName";
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);
            XmlElement Signature = WQH.Xml.Sign.SignXmlFile(xml, rsa, cer);



            


            Signature.AppendChild(Object);

            xml.RemoveAll();
            xml.AppendChild(Signature);
            return xml;
        }
    }
}
