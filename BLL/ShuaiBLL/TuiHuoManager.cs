using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL.ShuaiBLL
{
  public  class TuiHuoManager
    {
        public static ShuaiPageList TuiHuochaxun(int PageIndex, int PageSize) { 
            return DAL.ShuaiDAL.TuiHuoService.TuiHuochaxun(PageIndex,PageSize);
        }

        public static int GetRows2() {
            return DAL.ShuaiDAL.TuiHuoService.GetRows2();
        }

        public static int Tuihuoedit(int id) {
            return DAL.ShuaiDAL.TuiHuoService.Tuihuoedit(id);
        }

        public static ShuaiPageList TuiHuodaishenhe(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.TuiHuoService.TuiHuodaishenhe(PageIndex,PageSize);
        }

        public static ShuaiPageList TuiHuoTongHuo(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.TuiHuoService.TuiHuoTongHuo(PageIndex,PageSize);
        }

        public static ShuaiPageList TuiHuoShiBai(int PageIndex, int PageSize) {
            return DAL.ShuaiDAL.TuiHuoService.TuiHuoShiBai(PageIndex,PageSize);
        }

        public static ShuaiPageList AnMinzi(int PageIndex, int PageSize, string name) {
            return DAL.ShuaiDAL.TuiHuoService.AnMinzi(PageIndex,PageSize,name);
        }

        public static ShuaiPageList TuiHuoPageList2(int PageIndex, int PageSize, string name, DateTime sname, DateTime sname2)
        {
            return DAL.ShuaiDAL.TuiHuoService.TuiHuoPageList2(PageIndex,PageSize,name,sname,sname2);
        }


        public static ShuaiPageList TuiHuoPageList3(int PageIndex, int PageSize, DateTime sname, DateTime sname2)
        {
            return DAL.ShuaiDAL.TuiHuoService.TuiHuoPageList3(PageIndex,PageSize,sname,sname2);
        }
    }
}
