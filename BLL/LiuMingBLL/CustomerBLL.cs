using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.LiuMingDAL;
using Model;
namespace BLL.LiuMingBLL
{
    public class CustomerBLL
    {
        //查询所有
        public static IQueryable CustGetAll()
        {
            return CustomerDAL.CustGetAll();
        }

        //按客户名称查询
        public static IQueryable Custquery(string SName)
        {
            return CustomerDAL.Custquery(SName);
        }

        //新增客户
        public static int CustAdd(Customer cust)
        {
            return CustomerDAL.CustAdd(cust);
        }

        public static int CustomerDele(int id)
        {
            return CustomerDAL.CustomerDele(id);
        }
    }
}