using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServer.Models.BaiDu;
using WebServer.Models.KSOA;
using WebServer.Models.Request;
using WebServer.Models.WeChat;

namespace WebServer.Controllers
{
    public class WeChatController : ApiController
    {
        /// <summary>
        /// 获取openid
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public object Get_openid(P_Get_openid p)
        {
            try
            {
                openid openid = new openid(p.appid, p.code);
                return new { error = 0, msg = "查询成功", data = openid.value };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        [HttpGet]
        public object get_userInfo(string openid)
        {
            try
            {
                zhiydoc userInfo = zhiydoc.Get(zhiydoc.from_openid, openid);
                return new
                {
                    error = 0,
                    msg = "查询成功",
                    data = new
                    {
                        userInfo.dzyid,
                        userInfo.dzycode,
                        userInfo.dzyname,
                        userInfo.lgnname,
                        userInfo.is_ywy
                    }
                };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 首页商品展示
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public object Index_spList(P_Index_spList p)
        {
            try
            {
                var data = WX_index_sp.getList(p);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 商品检索
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public object sp_search(P_sp_search p)
        {
            try
            {
                var data = WX_sp_search.getList(p);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        [HttpPost]
        public object Sp_search_order(P_sp_search_order p)
        {
            try
            {
                var data = spkfk.search("WX_sp_search_order", p);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 商品信息
        /// </summary>
        /// <param name="spid"></param>
        /// <returns></returns>
        [HttpGet]
        public object sp_info(string spid)
        {
            try
            {
                var data = spkfk.get_sp(spid);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        [HttpPost]
        public object Search_spph(P_Search_spph p)
        {
            try
            {
                var data = sphwph.get_spph(p);
                return new { error = 0, msg = "查询成功", data };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 获取语音合成
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        [HttpGet]
        public object get_speech(string text)
        {
            try
            {
                var sp = wqh_speech_lib.Get(text);
                if (sp == null)
                {
                    string new_id = Guid.NewGuid().ToString();
                    sp = new wqh_speech_lib();
                    sp.text = text;
                    sp.URL = Speech.Tts(text, new_id);
                    sp.Add();
                }
                return new { error = 0, msg = "查询成功", data = new { sp.URL } };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 获取最大编号
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public object get_maxbh()
        {
            try
            {
                string maxbh = Models.KSOA.maxbh.get_maxbh("WXD");
                return new { error = 0, msg = "查询成功", data = new { maxbh } };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 绑定账号
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public object Binding_account(P_Binding_account p)
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
                    if (zhiydoc.Binding_account(user.dzyid, p.openid))
                    {
                        return new { error = 0, msg = "绑定成功" };
                    }
                    else
                    {
                        return new { error = 1, msg = "绑定失败" };
                    }
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
        /// 搜索单位
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        [HttpPost]
        public object search_dw(P_search_dw p)
        {
            try
            {
                return new { error = 0, msg = "查询成功", data = mchk.search_dw(p) };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        /// <summary>
        /// 单位联系人
        /// </summary>
        /// <param name="dwbh"></param>
        /// <returns></returns>
        [HttpGet]
        public object search_dwlxr(string dwbh)
        {
            try
            {
                return new { error = 0, msg = "查询成功", data = dwdydz.search_dwlxr(dwbh) };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 获取字典项
        /// </summary>
        /// <param name="fdname"></param>
        /// <returns></returns>
        [HttpGet]
        public object get_gldict(string fdname)
        {
            try
            {
                return new { error = 0, msg = "查询成功", data = gldict.get_gldict(fdname) };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
        /// <summary>
        /// 获取开票员
        /// </summary>
        /// <param name="fdname"></param>
        /// <returns></returns>
        [HttpGet]
        public object get_kpy()
        {
            try
            {
                var kpy = from i in zhiydoc.get_kpy() select i.dzyname;
                return new { error = 0, msg = "查询成功", kpy };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
       
        [HttpPost]
        public object submit_order(P_WX_order p)
        {
            try
            {
                string djbh = maxbh.get_maxbh("WXD");
                p.djbh = djbh;
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(P_WX_order.ConnectionString))
                {
                    conn.Open();
                    System.Data.SqlClient.SqlTransaction transaction = conn.BeginTransaction();
                    try {
                        if (!p.Save(conn, transaction)) {
                            throw new Exception("汇总存盘失败");
                        };

                        foreach (wqh_WX_order_mx i in p.mx) {
                            i.djbh = djbh;
                            i.Save(conn, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception e) {
                        transaction.Rollback();
                        return new { error = 1, msg = e.Message };
                    }
                    if (conn.State != System.Data.ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                    return new { error = 0, msg = "提交成功" };
                }
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        [HttpGet]
        public object get_pd_list()
        {
            try
            {
                var pd_list = Models.KSOA.pdhz.get_pd_list();
                return new { error = 0, msg = "查询成功", pd_list };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }

        [HttpGet]
        public object get_pdmx(string djbh)
        {
            try
            {
                var pdmx = Models.KSOA.pdmx.get_pdmx(djbh);
                return new { error = 0, msg = "查询成功", pdmx };
            }
            catch (Exception e)
            {
                return new { error = 1, msg = e.Message };
            }
        }
    }
}
