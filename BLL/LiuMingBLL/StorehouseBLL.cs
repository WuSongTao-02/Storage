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
    public class StorehouseBLL
    {
        StorehouseDAL dal = new StorehouseDAL();


        //查询所有
        public static IQueryable GetAll11()
        {
            return StorehouseDAL.GetAll11();
        }

        #region 按条件查询
        public static IQueryable querid(string store, string StName, string StoreName)
        {
            return StorehouseDAL.querid(store, StName, StoreName);
        }
        #endregion





    }
}