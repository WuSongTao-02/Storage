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
            if (BLL.WstBLL.WstLoginBLL.Login(name, pwd) > 0) {
                Session["name"] =name;
            }
            return Json(BLL.WstBLL.WstLoginBLL.Login(name, pwd), JsonRequestBehavior.AllowGet);
            
        }

        //首页
        public ActionResult Index() {
         
            return View();
        }
    }
}