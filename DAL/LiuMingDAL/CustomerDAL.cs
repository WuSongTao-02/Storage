using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.LiuMingDAL
{
    /// <summary>
    /// 客户管理
    /// </summary>
    public class CustomerDAL
    {
        #region 查询所有
        public static IQueryable CustGetAll()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Customer
                      select new
                      {
                          CusId = p.CusId,
                          CusName = p.CusName,
                          CusTel = p.CusTel,
                          IsDelete=p.IsDelete,
                          CreateTime = p.CreateTime
                      };
            return obj;
        }
        #endregion

        #region 按客户名称查询
        public static IQueryable Custquery(string SName)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Customer
                      where p.CusName.Contains(SName)
                      select new
                      {
                          CusId = p.CusId,
                          CusName = p.CusName,
                          CusTel = p.CusTel,
                          IsDelete = p.IsDelete,
                          CreateTime = p.CreateTime
                      };
            return obj;
        }
        #endregion


        #region 新增客户名称
        public static int CustAdd(Customer cust)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            contxt.Customer.Add(cust);
            return contxt.SaveChanges();
        }
        #endregion

        #region 删除客户
        public static int CustomerDele(int id)
        {
            CangChuEntities1 txtcon = new CangChuEntities1();
            var obj = (from p in txtcon.Customer
                       where p.CusId == id
                       select p).First();
            obj.IsDelete = 0;
            return txtcon.SaveChanges();
        }
        #endregion
    }
}
