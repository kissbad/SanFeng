using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebServer.Models.KSOA;
using WebServer.Models.Request;

namespace WebServer.Controllers
{
    public class WebApiController : ApiController
    {
        [HttpPost]
        public object Login(P_Login p)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(p.lgnname) || string.IsNullOrWhiteSpace(p.kl))
                {
                    return new { error = 1, msg = "账号或密码为空！" };
                }
                var user = zhiydoc.Login(p);
                if (user == null) { return new { error = 1, msg = "账号不存在" }; }
                if (PassWord.Discryptpassword(user.kl) == p.kl && user.beactive == "是")
                {
                    Token token = new Token(user, 30);
                    return new { error = 0, msg = "查询成功", data = token.token };
                }
                else if (PassWord.Discryptpassword(user.kl) != p.kl)
                {
                    return new { error = 1, msg = "密码错误" };
                }
                else if (user.beactive != "是")
                {
                    return new { error = 1, msg = "账号无效" };
                }
                else
                {
                    return new { error = 1, msg = "登录失败" };
                }
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        /// <summary>
        /// 用户信息，登录认证
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        public object User_info(string token)
        {
            try
            {
                zhiydoc zy = Token.Verify_token(token);
                return new { error = 0, msg = "认证成功", data = new { zy.dzyname } };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        /// <summary>
        /// 搜索商品
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        public object search_sp(P_search_sp p)
        {
            try
            {
                zhiydoc zy = Token.Verify_token(p.token);
                var spl = spkfk.search("WX_sp_search", new { p.keyword, p.pageIndex, p.pageSize });
                return new { error = 0, msg = "", data = spl };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public object Upload()
        {
            try
            {
                if (!Request.Content.IsMimeMultipartContent("form-data"))
                {
                    return new { error = 1, msg = "数据类型错误！" };
                }
                HttpFileCollection fc = HttpContext.Current.Request.Files;
                if (fc.Count == 0)
                {
                    return new { error = 1, msg = "无Files类型数据！" };
                }
                var Keys = fc.AllKeys;
                List<string> data = new List<string>();
                for (int i = 0; i < fc.Count; i++)
                {
                    string extension = Path.GetExtension(fc[i].FileName).ToLower();
                    if (".jpg|.gif|.png|.bmp|.psd|.svg|".IndexOf(extension) == -1)
                    {
                        throw new Exception("图片格式错误");
                    }
                    using (Stream s = fc[i].InputStream)
                    {
                        var imge = Image.FromStream(s);
                        var new_imge = WQH.system.IO.Image.Scaled(imge, 220, 220);

                        using (MemoryStream memory = new MemoryStream())
                        {
                            new_imge.Save(memory, ImageFormat.Jpeg);
                            memory.Seek(0, SeekOrigin.Begin);

                            var fileName = "image/" + Keys[i] + extension;
                            var oss = new Models.TaoBao.OSS();
                            var x = oss.Upload(memory, fileName).ToString();
                            spkfk.update_imageUrl(Keys[i], x);
                            data.Add(x);
                        }
                    }
                }
                return new { error = 0, msg = "", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
    }
}
