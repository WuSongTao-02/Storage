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
            CangChuEntities1 contxt = new CangChuEntities1();
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
        public static IQueryable querid(string store, string StName, string StoreName)
        {
            PageList list = new PageList();
            CangChuEntities1 contxt = new CangChuEntities1();
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

            if (store != "" || StName != "" || StoreName != "")
            {
                obj = obj.Where(p => p.SupName == store || p.StName == StName || p.StoreName == StoreName);
            }

            return obj;
        }
        #endregion


        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>数据集合</returns>
        public static IQueryable StorehouseById(int id) {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Storehouse
                      where p.StorId == id
                      select new
                      {
                          StorId=  p.StorId,
                          StoreName= p.StoreName,
                          Supid= p.Supid,
                          StId= p.StId,
                          IsMoren= p.IsMoren,
                      };
            return obj;
        }

        /// <summary>
        /// 库位类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable type() {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Storehousetype
                      select new { 
                        p.StName,
                        p.StId,
                      };
            return obj;
        }

        public static IQueryable cangchu() {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Supplier
                      select new
                      {
                          p.SupName,
                          p.SupId,
                      };
            return obj;
        }

        public static int update(Storehouse s) {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Storehouse where p.StorId == s.StorId select p).First();
            obj.StoreName = s.StoreName;
            obj.StId = s.StId;
            obj.IsMoren = s.IsMoren;
            obj.Supid = s.Supid;
            return entity.SaveChanges();
        }
    }
}