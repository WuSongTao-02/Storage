using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;
namespace DAL.LiuMingDAL
{
    /// <summary>
    /// 库位管理
    /// </summary>
   public class StorehouseDAL
    {
       

        #region 查询所有
        public static IQueryable GetAll11()
        {
            CangChuEntities contxt = new CangChuEntities();
            var obj = from p in contxt.Storehouse
                      select new
                      {
                          StorId = p.StorId,
                          StoreNum = p.StoreNum,
                          StoreName = p.StoreName,
                          SupName = p.Supplier.SupName,
                          StName = p.Storehousetype.StName,
                          IsJin = p.Storehousetype.IsJin,
                          IsMoren = p.IsMoren,
                          CreateTime = p.CreateTime

                      };
            return obj;
        }

        #endregion

        #region 按条件查询
        public static PageList querid(int pageIndex, int pagesize,string SupName,string StName,string StoreNum) 
        {
            PageList list = new PageList();
            CangChuEntities contxt = new CangChuEntities();
            var obj = from p in contxt.Storehouse
                      orderby p.StoreNum
                      where p.Supplier.SupName == SupName || p.Storehousetype.StName == StName || p.StoreNum == StoreNum
                      select new {
                          StorId = p.StorId,
                          StoreNum = p.StoreNum,
                          StoreName = p.StoreName,
                          SupName = p.Supplier.SupName,
                          StName = p.Storehousetype.StName,
                          IsJin = p.Storehousetype.IsJin,
                          IsMoren = p.IsMoren,
                          CreateTime = p.CreateTime
                      };
            list.Datalist = obj.Skip((pageIndex - 1) * pagesize).Take(pagesize);
            int row = contxt.Storehouse.Count();
            list.PageCount = row % pagesize == 0 ? row / pagesize : row / pagesize + 1;
            return list;
        }
        #endregion

        #region 新增
        public static int Add(Storehouse stroe)
        {
            CangChuEntities contxt = new CangChuEntities();
            contxt.Storehouse.Add(stroe);
            return contxt.SaveChanges();
        }

        #endregion

    }
}
