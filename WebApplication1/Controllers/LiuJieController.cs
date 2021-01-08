using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Model.Jie;
using BLL.LiuJIeBLL;

namespace WebApplication1.Controllers
{
    public class LiuJieController : Controller
    {
        // GET: LiuJie
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 产品页面分页查询
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPageListProbaict(int pageIndex, int pageSize)
        {
            return Json(ProbaictManager.PageListProbaict(pageIndex, pageSize), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品页面数据条数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRowsProbaict() {
            return Json(ProbaictManager.GetRows(),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMian() {
            return View();
        }

        /// <summary>
        /// 产品删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult GetDeleteProbaict(string id) {
            return Json(ProbaictManager.GetDelete(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据id查询产品
        /// </summary>
        /// <returns></returns>
        public ActionResult GetByIdProbaict(string id) {
            return Json(ProbaictManager.GetById(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品新增页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMianAdd() {
            return View();
        }

        /// <summary>
        /// 产品新增
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public ActionResult GetAddProbaict(Probaict p) {
            return Json(ProbaictManager.Add(p),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMianUpdate() {
            return View();
        }

        /// <summary>
        /// 产品修改
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUpdateProbaict(Probaict p) {
            return Json(ProbaictManager.Update(p),JsonRequestBehavior.AllowGet);
        }
    }
}