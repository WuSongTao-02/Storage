using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.WstDAL
{
   public  class WstDAL
    {
       static CangChuEntities entity = new CangChuEntities();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>受影响行数</returns>
        public static int Login(string name, string pwd) {
            var count = (from p in entity.Admin where p.UserName == name && p.PassWord == pwd&&p.IsDelete==0&&p.RoleId==1||p.RoleId==2 select p).Count();
            return count;
        }
    }
}
