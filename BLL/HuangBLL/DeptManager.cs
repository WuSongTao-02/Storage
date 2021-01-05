using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Huang;
using DAL;
using DAL.HuangDAL;
namespace BLL.HuangBLL
{
   public  class DeptManager
    {
        public static PageList PageListDemo(int pageindex, int pagesize)
        {
            return DeptService. PageListDemo(pageindex, pagesize);
        }


        public static int GetRows()
        {
            return DeptService.GetRows();
        }
    }
}
