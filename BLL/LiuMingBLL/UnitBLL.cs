using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using DAL.LiuMingDAL;
namespace BLL.LiuMingBLL
{
    public class UnitBLL
    {
        #region 查询所有
        public static IQueryable UnitGetAll()
        {
            return UnitDAL.UnitGetAll();
        }
        #endregion

        public static IQueryable Unitquery(string SName)
        {
            return UnitDAL.Unitquery(SName);
        }

        //添加单位名称
        public static int UnitAdd(Unit unit)
        {
            return UnitDAL.UnitAdd(unit);
        }

        public static int UnitDele(int id)
        {
            return UnitDAL.UnitDele(id);
        }

        public static IQueryable UnitByid(int id)
        {
            return UnitDAL.UnitByid(id);
        }
        public static int updataUnit(Unit u)
        {
            return UnitDAL.updataUnit(u);
        }
    }
}
