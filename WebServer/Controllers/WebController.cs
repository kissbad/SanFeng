using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServer.Controllers
{
    public class WebController : Controller
    {
        public ActionResult Login()
        {
            ViewBag.Title = "登录页";
            return View();
        }

        // GET: Web
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult sp_image()
        {
            return View();
        }

    }
}