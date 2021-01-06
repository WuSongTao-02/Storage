using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.ShuaiDAL
{
   public  class BaoSunService
    {
        public static IQueryable ChaXun() {
            CangChuEntities hh = new CangChuEntities();
            var obj = from p in hh.Damage
                      orderby p.Damid
                      select new { 
                      Damid=p.Damid,
                      DamType=p.DamType,
                      DamOrder=p.DamOrder,
                      DamPerson=p.DamPerson,
                      AudiId=p.AudiId,
                      CreateTime=p.CreateTime,
                      IsDelete=p.IsDelete,
                      Remake=p.Remake,
                      };
            return obj;
        }

        public static int GetRows() {
            CangChuEntities hh = new CangChuEntities();
            return hh.Damage.Count();
        }


        public static int edit(Damage d) {
            CangChuEntities hh = new CangChuEntities();
            var obj = hh.Damage.Where(p => p.IsDelete == d.IsDelete).FirstOrDefault();
            if (obj!=null) {
                obj.Damid = d.Damid;
                obj.DamType = d.DamType;
                obj.DamOrder = d.DamOrder;
                obj.DamPerson = d.DamPerson;
                obj.AudiId = d.AudiId;
                obj.CreateTime = d.CreateTime;
                obj.IsDelete = d.IsDelete;
                obj.Remake = d.Remake;
            }
            return hh.SaveChanges();
        }
        public static ShuaiPageList GetPageList(int PageIndex,int PageSize) {
            CangChuEntities hh = new CangChuEntities();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Damage
                      where p.IsDelete==0
                      orderby p.Damid 
                      select new {
                          Damid = p.Damid,
                          DamType = p.DamType,
                          DamOrder = p.DamOrder,
                          DamPerson = p.DamPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake,
                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }
    }
}
