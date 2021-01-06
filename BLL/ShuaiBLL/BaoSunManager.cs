using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL.ShuaiBLL
{
   public  class BaoSunManager
    {

        public static IQueryable ChaXun()
        {
            return DAL.ShuaiDAL.BaoSunService.ChaXun();
        }
        public static ShuaiPageList GetPageList(int PageIndex, int PageSize)
        {
            return DAL.ShuaiDAL.BaoSunService.GetPageList(PageIndex,PageSize);
        }
        public static int GetRows()
        {
            return DAL.ShuaiDAL.BaoSunService.GetRows();
        }
        public static int edit(Damage d)
        {
            return DAL.ShuaiDAL.BaoSunService.edit(d);
        }
        }
}
