using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Huang;
namespace DAL.HuangDAL
{
   public  class RoleService
    {

        public static IQueryable queryRole()
        {
            CangChuEntities1 entities1 = new CangChuEntities1();
            var obj = from p in entities1.Role
                      where p.IsDelete == 0
                      select new
                      {
                          id = p.RoleId,
                          name = p.RoleName
                      };
            return obj;
        }
        public static int GetRows()
        {
            CangChuEntities1 entities = new CangChuEntities1();
            return entities.Role.Count();
        }

        public static Model.Huang.PageList PageListDemo(int pageindex, int pagesize)
        {
            CangChuEntities1 entities = new CangChuEntities1();
           Model.Huang.PageList list = new Model.Huang.PageList();
            var obj = from p in entities.Role where p.IsDelete == 0
                      orderby p.RoleId
                      select new
                      {
                          RoleId = p.RoleId,
                          RoleName = p.RoleName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            int rows = entities.Role.Count();
            list.PageCount = rows % pagesize == 0 ? rows / pagesize : rows / pagesize + 1;
            return list;
        }

        public static IQueryable GetById(int RoleId)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Role
                      where p.RoleId == RoleId
                      select new
                      {
                          RoleId = p.RoleId,
                          RoleName = p.RoleName,
                          CreateTime = p.CreateTime,
                          Remake = p.Remake
                      };
            return obj;

        }

        public static int Edit(Role r)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Role where p.RoleId == r.RoleId select p).First();
            obj.RoleName = r.RoleName;
            return entity.SaveChanges();
        }

        

        public static int Add(Role r)
        {
            CangChuEntities1 entities = new CangChuEntities1();
            entities.Role.Add(r);
            return entities.SaveChanges();
        }

        public static int dele(Role r)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Role where p.RoleId == r.RoleId select p).First();
            obj.IsDelete = r.IsDelete;
            return entity.SaveChanges();
        }



    }
}
