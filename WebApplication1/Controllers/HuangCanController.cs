using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Huang;
using BLL.HuangBLL;
namespace WebApplication1.Controllers
{
    public class HuangCanController : Controller
    {
        // GET: HuangCan

        public ActionResult Query(Admin ad)
        {
            return Json(AdminManager.QueryTest(ad), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult queryDept()
        {
            return Json(DeptManager.queryDept(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult queryRole()
        {
            return Json(RoleManager.queryRole(), JsonRequestBehavior.AllowGet);
        }




        public ActionResult DemoPageList(int pageindex, int pagesize)
        {
            return Json(AdminManager.PageListDemo(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRows()
        {
            return Json(AdminManager.GetRows(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult dele(Admin ad)
        {
            return Json(AdminManager.dele(ad), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(Admin ad)
        {

            ad.CreateTime = DateTime.Now;
            return Json(AdminManager.Add(ad), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(Admin a)
        {
            return Json(AdminManager.Edit(a), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetById(int id)
        {
            return Json(AdminManager.GetById(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update()
        {
            return View();
        }





    }
}