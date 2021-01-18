using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using DAL.LiuMingDAL;

namespace BLL.LiuMingBLL
{
    public class VendorBLL
    {
        public static IQueryable GetAll()
        {
            return VendorDAL.GetAll();
        }
        public static int GetRows()
        {
            return VendorDAL.GetRows();
        }
        public static PageList PageListDemo(int pageIndex, int PageSize)
        {
            return VendorDAL.PageListDemo(pageIndex, PageSize);
        }

        public static PageList ShowByName(int pageIndex, int pageSize, int VenId, string VenName)
        {
            return VendorDAL.ShowByName(pageIndex, pageSize, VenId, VenName);
        }
        public static IQueryable ShowByName1(string name)
        {
            return VendorDAL.ShowByName1(name);
        }
        //添加供应商
        public static int VendorAdd(Vendor ven)
        {
            return VendorDAL.VendorAdd(ven);
        }
        //删除
        public static int VendorDele(int id)
        {
            return VendorDAL.VendorDele(id);
        }


        /// <summary>
        /// 根据id查供应商信息
        /// </summary>
        /// <param name="id">供应商id</param>
        /// <returns>数据集合</returns>
        public static IQueryable VendorByid(int id)
        {
            return VendorDAL.VendorByid(id);
        }

        public static int updataVendor(Vendor d)
        {
            return VendorDAL.updataVendor(d);
        }
        }
}