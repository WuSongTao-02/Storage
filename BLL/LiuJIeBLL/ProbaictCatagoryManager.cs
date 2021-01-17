using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;
using DAL.LiuJIeDAL;

namespace BLL.LiuJIeBLL
{
    public class ProbaictCatagoryManager
    {
        public static IQueryable GetProbaictCatagorySerivce()
        {
            return ProbaictCatagorySerivce.GetProbaictCatagorySerivce();
        }

            /// <summary>
            /// 数据分页
            /// </summary>
            /// <param name="pageIndex"></param>
            /// <param name="pageSize"></param>
            /// <returns></returns>
            public static Model.Jie.PageList GetPageListProbaictCatagory(int pageIndex, int pageSize)
        {
            return ProbaictCatagorySerivce.GetPageListProbaictCatagory(pageIndex,pageSize);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int GetAddProbaictCatagory(ProbaictCatagory p)
        {
            return ProbaictCatagorySerivce.GetAddProbaictCatagory(p);
        }

        /// <summary>
        /// 根据id查询数据分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="ProId"></param>
        /// <returns></returns>
        public static Model.Jie.PageList TiaoJianProidProbaictCatagory(int pageIndex, int pageSize, int ProId)
        {
            return ProbaictCatagorySerivce.TiaoJianProidProbaictCatagory(pageIndex,pageSize,ProId);
        }

            /// <summary>
            /// 删除
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            public static int GetDeleteProbaictCatagory(int id)
        {
            return ProbaictCatagorySerivce.GetDeleteProbaictCatagory(id);
        }

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable GetById(int id)
        {
            return ProbaictCatagorySerivce.GetById(id);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public static int GetUpdateProbaictCatagory(ProbaictCatagory pr)
        {
            return ProbaictCatagorySerivce.GetUpdateProbaictCatagory(pr);
        }

        /// <summary>
        /// 数据总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            return ProbaictCatagorySerivce.GetRows();
        }
        }
}
