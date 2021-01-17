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
    public class HcController : Controller
    {
        // GET: Hc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult DemoPageList(int pageindex, int pagesize)
        {
            return Json(RoleManager.PageListDemo(pageindex, pagesize), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRows()
        {
            return Json(RoleManager.GetRows(), JsonRequestBehavior.AllowGet);
        }


        public ActionResult dele(Role r)
        {
            return Json(RoleManager.dele(r), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(Role r)
        {
            r.CreateTime = DateTime.Now;
            return Json(RoleManager.Add(r), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(Role r)
        {
            return Json(RoleManager.Edit(r), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetById(int id)
        {
            return Json(RoleManager.GetById(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Update()
        {
            return View();
        }







    }
}