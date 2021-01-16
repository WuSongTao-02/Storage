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
        public static IQueryable querid(string store,string StName,string StoreName) 
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
            
            if (store!=""|| StName!=""|| StoreName!="")
            {
                obj = obj.Where(p => p.SupName==store||p.StName==StName ||p.StoreName==StoreName);
            }
           
            return obj;
        }
        #endregion

       

    }
}
