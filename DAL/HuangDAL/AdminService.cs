using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Huang;
namespace DAL.HuangDAL
{
   public  class AdminService
    {
        public static int GetRows()
        {
            CangChuEntities1 entities = new CangChuEntities1();
            return entities.Admin.Count();
        }

            public static Model.Huang.PageList PageListDemo(int pageindex, int pagesize)
        {
            CangChuEntities1 entities = new CangChuEntities1();
            Model.Huang.PageList list = new Model.Huang.PageList();
            var obj = from p in entities.Admin
                      where p.IsDelete == 0
                      orderby p.Id
                      select new
                      {
                          Id = p.Id,
                          UserName = p.UserName,
                          RealName = p.RealName,
                          RoleId = p.RoleId,
                          DeptId = p.DeptId,
                          Rname =p.Role.RoleName,
                          Dname=p.Dept.DeptName,
                          Email=p.Email,
                          phone=p.phone,
                          CreateTime =p.CreateTime,
                          IsDelete = p.IsDelete,
                          DeleteTime=p.DeleteTime,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);
            int rows = entities.Role.Count();
            list.PageCount = rows % pagesize == 0 ? rows / pagesize : rows / pagesize + 1;
            return list;
        }

        public static IQueryable GetById(int Id)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Admin
                      where p.Id == Id
                      select new
                      {
                          Id = p.Id,
                          UserName = p.UserName,
                          PassWord = p.PassWord,
                          RealName = p.RealName,
                          RoleId = p.RoleId,
                          DeptId = p.DeptId,
                          Email = p.Email,
                          phone = p.phone,
                          Remake = p.Remake
                      };
            return obj;

        }

        public static int Edit(Admin a)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Admin where p.Id == a.Id select p).First();
            //obj.RoleName = r.RoleName;
            obj.UserName = a.UserName;
            obj.RealName = a.RealName;
            obj.PassWord = a.PassWord;
            obj.RoleId = a.RoleId;
            obj.DeptId = a.DeptId;
            obj.Email = a.Email;
            obj.phone = a.phone;
            obj.Remake = a.Remake;
            return entity.SaveChanges();
        }

        public static int Add(Admin r)
        {
            CangChuEntities1 entities = new CangChuEntities1();
            entities.Admin.Add(r);
            return entities.SaveChanges();
        }

        public static int dele(Admin r)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Admin where p.Id == r.Id select p).First();
            obj.IsDelete = r.IsDelete;
            return entity.SaveChanges();
        }





    }
}
