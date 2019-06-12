using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Xml;
using WebServer.Models.Yaojian;

namespace WebServer.Controllers
{
    public class YaojianController : ApiController
    {
        /// <summary>
        /// 更新经营商品
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public object UpdateOperationCommodity()
        {
            try
            {
                long dataId = 0;
                int pageCount = 0;
                int total = 0;
                while (total >= pageCount)
                {
                    string url = string.Format("https://219.135.157.154:8445/data/clientAccept/toOperationCommodity.do?dataId={0}&resType=json", dataId);
                    HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    //webrequest.ClientCertificates.AddRange(WQH.Web.HTTP.Certificate.get_Certificates2(System.Security.Cryptography.X509Certificates.StoreName.My, "广东三丰医药有限公司"));

                    var cer = WQH.Web.HTTP.Certificate.get_Certificates2("E://三丰/广东三丰医药有限公司_签名证书.cer", "12345678");
                    var cer2 = WQH.Web.HTTP.Certificate.get_Certificates2("E://三丰/广东三丰医药有限公司_加密证书.cer", "12345678");

                    webrequest.ClientCertificates.Add(cer);
                    webrequest.ClientCertificates.Add(cer2);
                    

                    webrequest.Method = "post";
                    string request = WQH.Web.HTTP.Helper.GetString<object>(webrequest, null, null);

                    JObject jo = JObject.Parse(request);
                    Result<Paging<List<OperationCommodity>>> result = jo.ToObject<Result<Paging<List<OperationCommodity>>>>();
                    if (result.resultCode == 0)
                    {
                        if (dataId == 0) { OperationCommodity.clear(); }
                        dataId = result.data.dataId;
                        pageCount = result.data.pageCount;
                        total = result.data.total;
                        List<OperationCommodity> list = result.data.data;

                        foreach (var i in list)
                        {
                            i.save();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return new { error = 0, msg = "更新完成", data = "" };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message + e.StackTrace };
            }
        }
        /// <summary>
        /// 查询本地经营商品
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public object GetOperationCommodity()
        {
            try
            {
                var data = OperationCommodity.GetOperationCommodities();
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 更新往来企业库
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public object UpdateContactsBusiness()
        {
            try
            {
                long dataId = 0;
                int pageCount = 0;
                int total = 0;
                while (total >= pageCount)
                {
                    string url = string.Format("https://219.135.157.154:8445/data/clientAccept/toContactsBusiness.do?dataId={0}&resType=json", dataId);
                    HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(url);
                    webrequest.ClientCertificates.Add(WQH.Web.HTTP.Certificate.GetCertificateFromStore(
                    System.Security.Cryptography.X509Certificates.StoreName.My,
                    System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine,
                    "广东三丰医药有限公司"));
                    webrequest.Method = "post";
                    string request = WQH.Web.HTTP.Helper.GetString<object>(webrequest, null, null);

                    JObject jo = JObject.Parse(request);
                    Result<Paging<List<ContactsBusiness>>> result = jo.ToObject<Result<Paging<List<ContactsBusiness>>>>();
                    if (result.resultCode == 0)
                    {
                        if (dataId == 0) { ContactsBusiness.clear(); }
                        dataId = result.data.dataId;
                        pageCount = result.data.pageCount;
                        total = result.data.total;
                        List<ContactsBusiness> list = result.data.data;

                        foreach (var i in list)
                        {
                            i.save();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return new { error = 0, msg = "更新完成", data = "" };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 查询采购入库数据
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public object QueryCGRK(Models.Request.P_QueryCGRK p)
        {
            try
            {
                List<yjj_qyjk_cgrk> data = yjj_qyjk_cgrk.GetData(p.start_rq, p.end_rq);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 上传采购入库数据
        /// </summary>
        /// <returns></returns>
        public object UploadCGRK(List<yjj_qyjk_cgrk> cgrk)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.PreserveWhitespace = false;
                XmlElement Object = xml.CreateElement("Object");
                Object.SetAttribute("Id", "DataObjectId");
                XmlElement jh = xml.CreateElement("jh");
                jh.SetAttribute("xmlns", "http://cmsland.com/yjj_qyjk_cgrk.xsd");
                Object.AppendChild(jh);

                foreach (var i in cgrk)
                {
                    XmlElement dj = xml.CreateElement("dj");
                    dj.SetAttribute("djbh", i.djbh);
                    dj.SetAttribute("rqrq", i.rqrq);
                    dj.SetAttribute("ghqy", i.ghqy);
                    dj.SetAttribute("xsdh", i.xsdh);
                    dj.SetAttribute("yssb", i.yssb);
                    dj.SetAttribute("yskssj", i.yskssj.ToString());
                    dj.SetAttribute("ysjssj", i.ysjssj.ToString());
                    dj.SetAttribute("clr", i.clr);
                    dj.SetAttribute("ysjl", i.ysjl);
                    jh.AppendChild(dj);
                    foreach (var i2 in i.tm)
                    {
                        XmlElement tm = xml.CreateElement("tm");
                        tm.SetAttribute("bwm", i2.bwm);
                        tm.SetAttribute("bzgg", i2.bzgg);
                        tm.SetAttribute("scph", i2.scph);
                        tm.SetAttribute("scrq", i2.scrq);
                        tm.SetAttribute("yxqz", i2.yxqz);
                        tm.SetAttribute("sl", i2.sl.ToString());
                        dj.AppendChild(tm);
                    }
                }
                xml.AppendChild(Object);

                var cer = WQH.Web.HTTP.Certificate.GetCertificateFromStore(
                    System.Security.Cryptography.X509Certificates.StoreName.My,
                    System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine,
                    "广东三丰医药有限公司");

                System.Security.Cryptography.CspParameters cspParams = new System.Security.Cryptography.CspParameters();
                cspParams.KeyContainerName = "XML_DSIG_RSA_KEY";
                System.Security.Cryptography.RSACryptoServiceProvider rsaKey = new System.Security.Cryptography.RSACryptoServiceProvider(cspParams);


                XmlElement Signature = WQH.Xml.Sign.SignXmlFile(xml, rsaKey, cer);
                Signature.AppendChild(Object);

                xml.RemoveAll();
                xml.AppendChild(Signature);


                string url = "https://219.135.157.154:8445/data/clientAccept/toUploadFile.do";

                MultipartFormDataContent mfdc = new MultipartFormDataContent();
                mfdc.Add(new StringContent(xml.InnerXml), "signFile", "采购入库.xml");
                mfdc.Add(new StringContent("json"), "resType");


                HttpClientHandler handler = new HttpClientHandler();
                handler.ClientCertificates.Add(WQH.Web.HTTP.Certificate.GetCertificateFromStore(
                    System.Security.Cryptography.X509Certificates.StoreName.My,
                    System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine,
                    "广东三丰医药有限公司"));


                HttpClient client = new HttpClient(handler);
                client.MaxResponseContentBufferSize = 256000;
                client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
                HttpResponseMessage response = client.PostAsync(url, mfdc).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string resp = response.Content.ReadAsStringAsync().Result;
                    Result<string> res = JObject.Parse(resp).ToObject<Result<string>>();

                    if (res.resultCode == 0)
                    {
                        wqh_yj_UploadFileLog ulfl = new wqh_yj_UploadFileLog();
                        ulfl.upload_type = "采购入库";
                        ulfl.upload_state = "未处理";
                        ulfl.fid = res.data;
                        if (ulfl.Save())
                        {
                            return new { error = 0, msg = "上传成功" };
                        }
                        else
                        {
                            return new { error = 1, msg = "数据保存失败" };
                        }
                    }
                    else
                    {
                        return new { error = 1, msg = "上传失败", data = res.resultCode + res.resultText };
                    }
                }
                else
                {
                    return new { error = 1, msg = "网络错误", data = response.StatusCode };
                }
            }
            catch (HttpRequestException e)
            {
                return new { error = 1, msg = "系统错误", data = e.Message };
            }
        }
        /// <summary>
        /// 上传文件结果查询
        /// </summary>
        /// <param name="fid"></param>
        /// <returns></returns>
        [HttpPost]
        public object DowloadFileDeal(string fid)
        {
            try
            {
                string url = string.Format("https://219.135.157.154:8445/data/clientAccept/toDowloadFileDeal.do?fid={0}&resType=json", fid);

                HttpClientHandler handler = new HttpClientHandler();

                var cer = WQH.Web.HTTP.Certificate.get_Certificates2("E://三丰/广东三丰医药有限公司_签名证书.cer", "12345678");
                var cer2 = WQH.Web.HTTP.Certificate.get_Certificates2("E://三丰/广东三丰医药有限公司_加密证书.cer", "12345678");

                //var cer2 = WQH.Web.HTTP.Certificate.GetCertificateFromStore(
                //    System.Security.Cryptography.X509Certificates.StoreName.AddressBook,
                //    System.Security.Cryptography.X509Certificates.StoreLocation.CurrentUser,
                //    "广东三丰医药有限公司");

                var x = cer.HasPrivateKey;
                var x2 = cer2.HasPrivateKey;

                handler.ClientCertificates.Add(cer);
                handler.ClientCertificates.Add(cer2);

                HttpClient client = new HttpClient(handler);

                client.MaxResponseContentBufferSize = 256000;
                client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");
                WQH.system.IO.File.WriteLog("sss", 1);
                HttpResponseMessage response = client.GetAsync(url).Result;
                WQH.system.IO.File.WriteLog(handler.ClientCertificates.Count.ToString(), 1);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string resp = response.Content.ReadAsStringAsync().Result;
                    Result<DowloadFileDeal> res = JObject.Parse(resp).ToObject<Result<DowloadFileDeal>>();

                    if (res.resultCode == 0)
                    {
                        return new { error = 0, msg = "查询成功", res.data };
                    }
                    else
                    {
                        return new { error = 1, msg = "查询失败", data = res.resultCode + res.resultText };
                    }
                }
                else
                {
                    return new { error = 1, msg = response.StatusCode };
                }
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message + e.StackTrace};
            }
        }
    }
}