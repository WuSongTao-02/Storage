using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.ShuaiDAL
{
    public  class TuiHuoService
    {



        public static ShuaiPageList TuiHuochaxun(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Comeback
                      where p.IsDelete==0
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        public static int GetRows2()
        {
            CangChuEntities1 hh = new CangChuEntities1();
            return hh.Comeback.Count();
        }


        public static int Tuihuoedit(int id)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            var obj = hh.Comeback.Where(p => p.CobId == id).FirstOrDefault();
            if (obj != null)
            {

                obj.IsDelete = 1;

            }
            return hh.SaveChanges();
        }


        public static ShuaiPageList TuiHuodaishenhe(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Comeback
                      where p.AudiId==1
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }


        public static ShuaiPageList TuiHuoTongHuo(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Comeback
                      where p.AudiId == 2
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        public static ShuaiPageList TuiHuoShiBai(int PageIndex, int PageSize)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Comeback
                      where p.AudiId == 3
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }


        public static ShuaiPageList AnMinzi(int PageIndex, int PageSize,string name)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Comeback
                      where p.CobType.Contains(name)
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

        public static ShuaiPageList TuiHuoPageList2(int PageIndex, int PageSize, string name, DateTime sname, DateTime sname2)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
          
            var obj = from p in hh.Comeback
                      where p.CobType.Contains(name)&&p.CreateTime>=sname&&p.CreateTime<=sname2
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }


        public static ShuaiPageList TuiHuoPageList3(int PageIndex, int PageSize, DateTime sname, DateTime sname2)
        {
            CangChuEntities1 hh = new CangChuEntities1();
            ShuaiPageList list = new ShuaiPageList();
            var obj = from p in hh.Comeback
                      where  p.CreateTime >= sname && p.CreateTime <= sname2
                      orderby p.CobId
                      select new
                      {
                          CobId = p.CobId,
                          CobType = p.CobType,
                          DeliId = from jj in hh.Deliver select jj.DeliId,
                          CobPerson = p.CobPerson,
                          AudiId = p.AudiId,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          comNum = from kk in hh.CombackStorage select kk.ComNum,

                      };
            list.DataList = obj.Skip((PageIndex - 1) * PageSize).Take(PageSize);
            int rows = hh.Damage.Count();
            list.PageCoun = rows % PageSize == 0 ? rows / PageSize : rows / PageSize + 1;
            return list;
        }

    }
}
