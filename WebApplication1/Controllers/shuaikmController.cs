using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;

namespace WebApplication1.Controllers
{
    public class shuaikmController : Controller
    {
        // GET: shuaikm
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChaXun() {

            return Json(BLL.ShuaiBLL.BaoSunManager.ChaXun(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRows() {
            return Json(BLL.ShuaiBLL.BaoSunManager.GetRows(), JsonRequestBehavior.AllowGet);


        }
        public ActionResult edit(Damage d)
        {
            return Json(BLL.ShuaiBLL.BaoSunManager.edit(d),JsonRequestBehavior.AllowGet);
        }
            public ActionResult GetPageList(int PageIndex, int PageSize){

            return Json(BLL.ShuaiBLL.BaoSunManager.GetPageList(PageIndex,PageSize),JsonRequestBehavior.AllowGet);
            }
    }
}