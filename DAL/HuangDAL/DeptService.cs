using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Huang;
namespace DAL.HuangDAL
{
   public  class DeptService
    {
        public static int GetRows()
        {
            
            CangChuEntities entities = new CangChuEntities();
            return entities.Dept.Count();
        }

        public static PageList PageListDemo(int pageindex, int pagesize)
        {
            CangChuEntities entities = new CangChuEntities();
            PageList list = new PageList();
            var obj = from p in entities.Dept
                      orderby p.DeptId
                      select new
                      {
                          DeptId = p.DeptId,
                          DeptName = p.DeptName,
                          CreateTime = p.CreateTime,
                          IsDelete = p. IsDelete,
                          Remake=p.Remake
                      };
            //设置分页数据
            list.DataList = obj.Skip((pageindex - 1) * pagesize).Take(pagesize);

            int rows = entities.Dept.Count();
            //设置总页数
            list.PageCount = rows % pagesize == 0 ? rows / pagesize : rows / pagesize + 1;
            return list;

        }
    }
}
