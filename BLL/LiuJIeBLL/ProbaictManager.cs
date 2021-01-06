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
        public static IQueryable GetProbaict(int pageIndex, int pageSize)
        {
            return ProbaictSerivce.GetProbaict(pageIndex, pageSize);
        }
        public static PageList PageListProbaict(int pageIndex, int pageSize)
        {
            return ProbaictSerivce.PageListProbaict(pageIndex, pageSize);
        }
        public static int GetRows()
        {
            return ProbaictSerivce.GetRows();
        }
    }
}
