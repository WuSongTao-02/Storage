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


        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns>数据集合</returns>
        public static IQueryable StorehouseById(int id)
        {
            return StorehouseDAL.StorehouseById(id);
        }


        /// <summary>
        /// 库位类型
        /// </summary>
        /// <returns></returns>
        public static IQueryable type()
        {
            return StorehouseDAL.type();
        }
        public static IQueryable cangchu()
        {
            return StorehouseDAL.cangchu();
        }

        public static int update(Storehouse s)
        {
            return StorehouseDAL.update(s);
        }
        }
}