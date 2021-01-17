using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Jie;

namespace DAL.LiuJIeDAL
{
    public class ProbaictCatagorySerivce
    {
        static CangChuEntities1 entity = new CangChuEntities1();

        public static IQueryable GetProbaictCatagorySerivce() {
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

        /// <summary>
        /// 数据分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static Model.Jie.PageList GetPageListProbaictCatagory(int pageIndex, int pageSize) {
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.ProbaictCatagory
                      where p.IsDelete == 0
                      orderby p.ProCId
                      select new
                      {
                          ProCId = p.ProCId,
                          ProCName = p.ProCName,
                          ProCCreteName = p.ProCCreteName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 根据id查询分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="ProId"></param>
        /// <returns></returns>
        public static Model.Jie.PageList TiaoJianProidProbaictCatagory(int pageIndex, int pageSize, int ProId)
        {
            Model.Jie.PageList list = new Model.Jie.PageList();
            var obj = from p in entity.ProbaictCatagory
                      where p.ProCId == ProId
                      orderby p.ProCId
                      select new
                      {
                          ProCId = p.ProCId,
                          ProCName = p.ProCName,
                          ProCCreteName = p.ProCCreteName,
                          CreateTime = p.CreateTime,
                          IsDelete = p.IsDelete,
                          Remake = p.Remake
                      };
            list.DataList = obj.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            int rows = entity.Probaict.Count();
            list.PageCount = rows % pageSize == 0 ? rows / pageSize : rows / pageSize + 1;
            return list;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int GetAddProbaictCatagory(ProbaictCatagory p) {
            entity.ProbaictCatagory.Add(p);
            return entity.SaveChanges();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetDeleteProbaictCatagory(int id) {
            var obj = (from p in entity.ProbaictCatagory where p.ProCId == id select p).First();
            if (obj != null) {
                obj.IsDelete = 1;
            }
            return entity.SaveChanges();
        }

        /// <summary>
        /// 根据id查询
        /// </summary>
        /// <returns></returns>
        public static IQueryable GetById(int id)
        {
            var obj = from p in entity.ProbaictCatagory
                      where p.ProCId == id
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

        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public static int GetUpdateProbaictCatagory(ProbaictCatagory pr) {
            var obj = (from p in entity.ProbaictCatagory where p.ProCId == pr.ProCId select p).First();
            obj.ProCId = pr.ProCId;
            obj.ProCName = pr.ProCName;
            obj.ProCCreteName = pr.ProCCreteName;
            obj.CreateTime = pr.CreateTime;
            obj.IsDelete = pr.IsDelete;
            obj.Remake = pr.Remake;
            return entity.SaveChanges();
        }

        /// <summary>
        /// 数据总条数
        /// </summary>
        /// <returns></returns>
        public static int GetRows()
        {
            return entity.ProbaictCatagory.Count();
        }
    }
}
