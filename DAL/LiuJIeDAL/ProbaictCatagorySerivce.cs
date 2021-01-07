using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.LiuJIeDAL
{
    public class ProbaictCatagorySerivce
    {
        static CangChuEntities entity = new CangChuEntities();

        public static IQueryable GetProbaictCatagory() {
            var obj = from p in entity.ProbaictCatagory
                      select new
                      {
                          ProCId = p.ProCId,
                          ProCName = p.ProCName,
                          ProCCreteName = p.ProCCreteName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            return obj;
        }
    }
}
