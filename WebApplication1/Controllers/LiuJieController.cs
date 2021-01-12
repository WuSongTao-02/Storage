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
        /// 产品页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMian() {
            return View();
        }

        /// <summary>
        /// 产品新增页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMianAdd()
        {
            return View();
        }

        /// <summary>
        /// 产品修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChanPingYeMianUpdate()
        {
            return View();
        }

        /// <summary>
        /// 产品分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult GetPageListProbaict(int pageIndex, int pageSize) {
            return Json(ProbaictManager.PageListProbaict(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品数据条数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRowsProbaict() {
            return Json(ProbaictManager.GetRows(),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品条件分页查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="ProId"></param>
        /// <returns></returns>
        public ActionResult GetTiaoJianPageListProbaict(int pageIndex, int pageSize,string ProId) {
            return Json(ProbaictManager.TiaoJianPageListProbaict(pageIndex,pageSize,ProId),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品删除
        /// </summary>
        /// <returns></returns>
        public ActionResult GetDeleteProbaict(string  id) {
            return Json(ProbaictManager.GetDelete(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 产品修改
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUpdateProbaict(Probaict pr) {
            return Json(ProbaictManager.Update(pr),JsonRequestBehavior.AllowGet);
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
        /// 根据id查询产品
        /// </summary>
        /// <returns></returns>
        public ActionResult GetByIdProbaict(string id) {
            return Json(ProbaictManager.GetById(id),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询ProbaictCatagory表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetProbaictCatagory() {
            return Json(ProbaictCatagoryManager.GetProbaictCatagory(),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 查询Unit表
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUnit() {
            return Json(UnitManager.GetUnit(),JsonRequestBehavior.AllowGet);
        }

        //入库页面
        public ActionResult RuKuYeMian() {
            return View();
        }

        //入库新增页面
        public ActionResult RuKuYeMianAdd()
        {
            return View();
        }

        //入库修改页面
        public ActionResult RuKuYeMianUpdate()
        {
            return View();
        }

        /// <summary>
        /// 出库页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuKuYeMian() {
            return View();
        }

        /// <summary>
        /// 出库新增页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuKuYeMianAdd()
        {
            return View();
        }

        /// <summary>
        /// 出库修改页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ChuKuYeMianUpdate()
        {
            return View();
        }
    }
}