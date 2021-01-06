using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;

namespace DAL.LiuJIeDAL
{
    public class ProbaictSerivce
    {
        static CangChuEntities entity = new CangChuEntities();

        public static IQueryable GetProbaict(int pageIndex, int pageSize) {
            PageList list = new PageList();
            var obj = from p in entity.Probaict
                      orderby p.ProId
                      select new
                      {
                          ProId = p.ProId,
                          ProName = p.ProName,
                          ProPrice = p.ProPrice,
                          PorGuiGe = p.PorGuiGe,
                          ProCId = from pp in entity.ProbaictCatagory select pp.ProCName,
                          UnId = from ppp in entity.Unit select ppp.UnName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          ProNumber = p.ProNumber,
                          ProJinhuo = p.ProJinhuo,
                          ProChuhuo = p.ProChuhuo,
                          ProBaosun = p.ProBaosun,
                          Remake = p.Remake
                      };
            return obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        public static PageList PageListProbaict(int pageIndex, int pageSize) {
            PageList list = new PageList();
            var obj = from p in entity.Probaict
                      orderby p.ProId
                      select new
                      {
                          ProId = p.ProId,
                          ProName = p.ProName,
                          ProPrice = p.ProPrice,
                          PorGuiGe = p.PorGuiGe,
                          ProCId = from pp in entity.ProbaictCatagory select pp.ProCName,
                          UnId = from ppp in entity.Unit select ppp.UnName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          ProNumber = p.ProNumber,
                          ProJinhuo = p.ProJinhuo,
                          ProChuhuo = p.ProChuhuo,
                          ProBaosun = p.ProBaosun,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        public static int GetRows() {
            return entity.Probaict.Count();
        }
    }
}
