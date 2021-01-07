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
    public class ProbaictManager
    {
        /// <summary>
        /// 数据分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PageList PageListProbaict(int pageIndex, int pageSize)
        {
            return ProbaictSerivce.PageListProbaict(pageIndex, pageSize);
        }

        /// <summary>
        /// 总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            return ProbaictSerivce.GetRows();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetDelete(string id)
        {
            return ProbaictSerivce.GetDelete(id);
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int Add(Probaict p)
        {
            return ProbaictSerivce.Add(p);
        }
        }
}
