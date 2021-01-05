using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;

namespace WebApplication1.Controllers
{
    public class WSTController : Controller
    {
        // GET: WST
       //登录页面
        public ActionResult Login()
        {
            return View();
        }
        //登录
        public ActionResult Logins(string name, string pwd) {
            return Json(BLL.WstBLL.WSTBLL.Login(name, pwd), JsonRequestBehavior.AllowGet);
        }
    }
}