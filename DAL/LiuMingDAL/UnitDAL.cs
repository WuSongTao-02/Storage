using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DAL.LiuMingDAL
{
    /// <summary>
    /// 单位管理
    /// </summary>
   public class UnitDAL
    {
        #region 查询所有
        public static IQueryable UnitGetAll()
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Unit
                      select new
                      {
                          UnId= p.UnId,
                          UnName=p.UnName,
                          IsDelete=p.IsDelete
                      };
            return obj;
        }
        #endregion


        #region 条件查询
        public static IQueryable Unitquery(string SName)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            var obj = from p in contxt.Unit where  p.UnName==SName
                      select new
                      {
                          UnId = p.UnId,
                          UnName = p.UnName,
                           IsDelete = p.IsDelete
                      };
            return obj;
        }
        #endregion

        #region 添加单位名称
        public static int UnitAdd(Unit unit)
        {
            CangChuEntities1 contxt = new CangChuEntities1();
            contxt.Unit.Add(unit);
            return contxt.SaveChanges();
        }
        #endregion

        #region 删除单位名称
        public static int UnitDele(int id)
        {
            CangChuEntities1 txtcon = new CangChuEntities1();
            var obj = (from p in txtcon.Unit
                       where p.UnId == id
                       select p).First();
            obj.IsDelete = 0;
            return txtcon.SaveChanges();
        }
        #endregion

        #region 根据单位查id信息
        public static IQueryable UnitByid(int id)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = from p in entity.Unit
                      where p.UnId == id
                      select new
                      {
                          UnId= p.UnId,
                          UnName=p.UnName,
                          IsDelete=p.IsDelete
                      };
            return obj;
        }


        public static int updataUnit(Unit u)
        {
            CangChuEntities1 entity = new CangChuEntities1();
            var obj = (from p in entity.Unit where p.UnId == u.UnId select p).First();
            obj.UnName = u.UnName;
            obj.IsDelete = u.IsDelete;
            return entity.SaveChanges();

        }
        #endregion
    }
}
