using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using DAL.HuangDAL;
namespace BLL.HuangBLL
{
   public  class AdminManager
    {

        public static Model.Huang.PageList PageListDemo(int pageindex, int pagesize)
        {
            return AdminService.PageListDemo(pageindex, pagesize);
        }

        public static int GetRows()
        {
            return AdminService.GetRows();
        }

        public static int dele(Admin ad)
        {
            return AdminService.dele(ad);
        }

        public static int Add(Admin ad)
        {
            return AdminService.Add(ad);
        }

        public static IQueryable GetById(int id)
        {
            return AdminService.GetById(id);
        }

        public static int Edit(Admin ad)
        {
            return AdminService.Edit(ad);
        }

    }
}
