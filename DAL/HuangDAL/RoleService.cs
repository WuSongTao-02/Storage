﻿using System;
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
        public static int GetRows()
        {

            CangChuEntities entities = new CangChuEntities();
            return entities.Role.Count();
        }

        public static PageList PageListDemo(int pageindex, int pagesize)
        {
            CangChuEntities entities = new CangChuEntities();
            PageList list = new PageList();
            var obj = from p in entities.Role
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
            CangChuEntities entity = new CangChuEntities();
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
            CangChuEntities entity = new CangChuEntities();
            var obj = (from p in entity.Role where p.RoleId == r.RoleId select p).First();
            obj.RoleName = r.RoleName;
            obj.CreateTime = r.CreateTime;
            obj.Remake =r.Remake;
            return entity.SaveChanges();
        }

        public static int Del(int RoleId)
        {
            CangChuEntities entities = new CangChuEntities();
            var obj = (from p in entities.Role where p.RoleId == RoleId select p).First();
            entities.Role.Remove(obj);
            return entities.SaveChanges();
        }

        public static int Add(Role r)
        {
            CangChuEntities entities = new CangChuEntities();

            entities.Role.Add(r);
            return entities.SaveChanges();
        }





    }
}
