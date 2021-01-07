﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Jie;
using BLL.LiuJIeBLL;

namespace WebApplication1.Controllers
{
    public class JieController : Controller
    {
        // GET: Jie
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 产品页
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPing() {
            return View();
        }
        /// <summary>
        /// 产品数据分页
        /// </summary>
        /// <returns></returns>
        public ActionResult PageListProbaict(int pageIndex,int pageSize) {
            return Json(ProbaictManager.PageListProbaict(pageIndex,pageIndex),JsonRequestBehavior.AllowGet) ;
        }
        /// <summary>
        /// 数据条数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRows() {
            return Json(ProbaictManager.GetRows(),JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetDelete(string id) {
            return Json(ProbaictManager.GetDelete(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品新增页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingAdd() {
            return View();
        }

        /// <summary>
        /// 产品修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingUpdate() {
            return View();
        }
    }
}