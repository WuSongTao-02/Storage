using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.LiuMingDAL
{
    /// <summary>
    /// 供应商管理
    /// </summary>
    public class VendorDAL
    {
        /// <summary>
        /// 获取数据表的总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            return contxt.Vendor.Count();
        }

        public static PageList PageListDemo(int pageIndex, int PageSize)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            //实例化分页类
            PageList list = new PageList();
            var obj = from p in contxt.Vendor
                      orderby p.VenId
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            //设置分页数据
            list.DataList = obj.Skip((pageIndex - 1) * PageSize).Take(PageSize);

            int rows = contxt.Vendor.Count();
            //设置总页数
            list.PageCount = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        #region 查询所有
        public static IQueryable GetAll()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Vendor
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake

                      };
            return obj;
        }
        #endregion

        #region 根据编号或名称进行查询
        //
        public static PageList ShowByName(int pageIndex, int pageSize, int VenId, string VenName)
        {
            PageList list = new PageList();
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Vendor
                      orderby p.VenId
                      where p.VenId == VenId || p.VenName == VenName
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.Datalist = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int row = contxt.Vendor.Count();
            list.PageCount = row % pageSize == 0 ? row / pageSize : row / pageSize + 1;
            return list;
        }
        #endregion

        public static IQueryable ShowByName1(string name)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Vendor
                      select new
                      {
                          VenId = p.VenId,
                          VenType = p.VenType,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          Remake = p.Remake
                      };
            if (!string.IsNullOrEmpty(name)) {
                obj = obj.Where(p => p.VenName.Contains(name));
            }
            return obj;
        }

        #region 添加供应商
        public static int VendorAdd(Vendor ven)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            contxt.Vendor.Add(ven);
            return contxt.SaveChanges();
        }
        #endregion

        #region 删除供应商
        public static int VendorDele(int id)
        {
            CangChuEntities1 txtcon = new CangChuEntities1();
            var obj = (from p in txtcon.Vendor
                       where p.VenId == id
                       select p).First();
            obj.IsDelete = 0;
            return txtcon.SaveChanges();
        }
        #endregion


        /// <summary>
        /// 根据id查供应商信息
        /// </summary>
        /// <param name="id">供应商id</param>
        /// <returns>数据集合</returns>
        public static IQueryable VendorByid(int id)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Vendor
                      where p.VenId == id
                      select new
                      {
                          VenId = p.VenId,
                          VenName = p.VenName,
                          VenTel = p.VenTel,
                          VenEmain = p.VenEmain,
                          VenPerson = p.VenPerson,
                          VenAddress = p.VenAddress,
                          Remake = p.Remake,
                          VenType = p.VenType,
                      };
            return obj;
        }

        public static int updataVendor(Vendor d) {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Vendor where p.VenId == d.VenId select p).First();
            obj.VenName = d.VenName;
            obj.VenEmain = d.VenEmain;
            obj.VenTel = d.VenTel;
            obj.VenAddress = d.VenAddress;
            obj.VenPerson = d.VenPerson;
            obj.VenType = d.VenType;
            obj.Remake = d.Remake;
            return entity.SaveChanges();

        }
    }
}