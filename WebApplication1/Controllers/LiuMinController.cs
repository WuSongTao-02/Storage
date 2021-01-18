using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL.LiuMingBLL;

namespace WebApplication1.Controllers
{
    public class LiuMinController : Controller
    {
        // GET: LiuMin

        #region 库位管理
        public ActionResult Index()
        {
            return View();
        }

        //库位管理查询所有
        public ActionResult GetAll11()
        {
            return Json(StorehouseBLL.GetAll11(), JsonRequestBehavior.AllowGet);
        }

        //按条件查询
        public ActionResult querid(string store, string StName, string StoreName)
        {
            return Json(StorehouseBLL.querid(store, StName, StoreName), JsonRequestBehavior.AllowGet);
        }



        #endregion


        #region 客户管理
        //客户表
        public ActionResult CustIndex()
        {
            return View();
        }
        //客户管理表查询所有
        public ActionResult CustGetAll()
        {
            return Json(CustomerBLL.CustGetAll(), JsonRequestBehavior.AllowGet);
        }

        //按客户名称查询
        public ActionResult Custquery(string SName)
        {
            return Json(CustomerBLL.Custquery(SName), JsonRequestBehavior.AllowGet);
        }

        //添加客户
        public ActionResult CustAdd(Customer cust)
        {
            return Json(CustomerBLL.CustAdd(cust), JsonRequestBehavior.AllowGet);
        }

        //删除客户信息
        public ActionResult CustomerDele(int id)
        {
            return Json(CustomerBLL.CustomerDele(id), JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 供应商管理
        public ActionResult VendorIndex()
        {
            return View();
        }
        //供应商管理查询所有
        public ActionResult GetAll()
        {
            return Json(VendorBLL.GetAll(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetRows()
        {
            return Json(VendorBLL.GetRows(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult PageListDemo(int pageIndex, int PageSize)
        {
            return Json(VendorBLL.PageListDemo(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }

        //根据供应商用户名或工号查询
        public ActionResult ShowByName(int pageIndex, int pageSize, int VenId, string VenName)
        {
            return Json(VendorBLL.ShowByName(pageIndex, pageSize, VenId, VenName), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowByName1(string name)
        {
            return Json(VendorBLL.ShowByName1(name), JsonRequestBehavior.AllowGet);
        }
        public ActionResult aaaa(string name)
        {
            return Json(VendorBLL.ShowByName1(name), JsonRequestBehavior.AllowGet);
        }
        //添加供应商
        public ActionResult VendorAdd(Vendor ven)
        {
            return Json(VendorBLL.VendorAdd(ven), JsonRequestBehavior.AllowGet); ;
        }

        //删除供应商
        public ActionResult VendorDele(int id)
        {
            return Json(VendorBLL.VendorDele(id), JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 单位管理

        public ActionResult UnitIndex()
        {
            return View();
        }
        //查询所有
        public ActionResult UnitGetAll()
        {
            return Json(UnitBLL.UnitGetAll(), JsonRequestBehavior.AllowGet);
        }

        //按编号查询
        public ActionResult Unitquery(string SName)
        {
            return Json(UnitBLL.Unitquery(SName), JsonRequestBehavior.AllowGet);
        }

        //添加单位名称
        public ActionResult UnitAdd(Unit unit)
        {
            return Json(UnitBLL.UnitAdd(unit), JsonRequestBehavior.AllowGet);
        }

        //删除单位名称
        public ActionResult UnitDele(int id)
        {
            return Json(UnitBLL.UnitDele(id), JsonRequestBehavior.AllowGet);
        }
        #endregion



        //产品类别修改
        public ActionResult StorehouseById() {
            return View();
        }
        public ActionResult StorehouseByIds(int id) {
            return Json(StorehouseBLL.StorehouseById(id),JsonRequestBehavior.AllowGet);
        }
        //库位类型
        public ActionResult type() {
            return Json(StorehouseBLL.type(),JsonRequestBehavior.AllowGet);
        }
        public ActionResult cangku() {
            return Json(StorehouseBLL.cangchu(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult updateStor(Storehouse s) {


            return Json(StorehouseBLL.update(s), JsonRequestBehavior.AllowGet);
        }


        //客户修改
        public ActionResult VendorByid() {
            return View();
        }
        public ActionResult VendorByids(int id) {
            return Json(VendorBLL.VendorByid(id), JsonRequestBehavior.AllowGet);
        }
        public ActionResult updataVendor(Vendor d) {
            return Json(VendorBLL.updataVendor(d), JsonRequestBehavior.AllowGet);
        }

        //单位修改
        public ActionResult UnitByid()
        {
            return View();
        }
        public ActionResult UnitByids(int id)
        {
            return Json(UnitBLL.UnitByid(id),JsonRequestBehavior.AllowGet);
        }
        public ActionResult updataUnit(Unit u)
        {
            return Json(UnitBLL.updataUnit(u),JsonRequestBehavior.AllowGet);
        }
    }
}