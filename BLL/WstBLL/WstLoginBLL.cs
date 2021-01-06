using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL.WstBLL
{
    public class WstLoginBLL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>受影响行数</returns>
        public static int Login(string name, string pwd)
        {
            return DAL.WstDAL.WstLoginDAl.Login(name, pwd);
        }

        }
}
