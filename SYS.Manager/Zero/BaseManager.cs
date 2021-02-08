using SYS.Application;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Manager
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseManager
    {

        #region 性别模块

        /// <summary>
        /// 查询所有性别类型
        /// </summary>
        /// <returns></returns>
        public List<SexType> SelectSexTypeAll()
        {
            return new BaseService().SelectSexTypeAll();
        }

        /// <summary>
        /// 查询性别类型
        /// </summary>
        /// <returns></returns>
        public SexType SelectSexType(SexType sexType)
        {
            return new BaseService().SelectSexType(sexType);
        }

        /// <summary>
        /// 添加性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int AddSexType(SexType sexType)
        {
            return new BaseService().AddSexType(sexType);
        }

        /// <summary>
        /// 删除性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int DelSexType(SexType sexType)
        {
            return new BaseService().DelSexType(sexType);
        }

        /// <summary>
        /// 更新性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int UpdSexType(SexType sexType)
        {
            return new BaseService().UpdSexType(sexType);
        }

        #endregion

        #region 职位模块

        /// <summary>
        /// 查询所有职位类型
        /// </summary>
        /// <returns></returns>
        public List<Position> SelectPositionAll()
        {
            return new BaseService().SelectPositionAll();
        }

        /// <summary>
        /// 查询职位类型
        /// </summary>
        /// <returns></returns>
        public Position SelectPosition(Position position)
        {
            return new BaseService().SelectPosition(position);
        }

        /// <summary>
        /// 添加职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int AddPosition(Position position)
        {
            return new BaseService().AddPosition(position);
        }

        /// <summary>
        /// 删除职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int DelPosition(Position position)
        {
            return new BaseService().DelPosition(position);
        }

        /// <summary>
        /// 更新职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int UpdPosition(Position position)
        {
            return new BaseService().UpdPosition(position);
        }

        #endregion

        #region 民族模块

        /// <summary>
        /// 查询所有民族类型
        /// </summary>
        /// <returns></returns>
        public List<Nation> SelectNationAll()
        {
            return new BaseService().SelectNationAll();
        }

        /// <summary>
        /// 查询民族类型
        /// </summary>
        /// <returns></returns>
        public Nation SelectNation(Nation nation)
        {
            return new BaseService().SelectNation(nation);
        }

        /// <summary>
        /// 添加民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public int AddNation(Nation nation)
        {
            return new BaseService().AddNation(nation);
        }

        /// <summary>
        /// 删除民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public int DelNation(Nation nation)
        {
            return new BaseService().DelNation(nation);
        }

        /// <summary>
        /// 更新民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public int UpdNation(Nation nation)
        {
            return new BaseService().UpdNation(nation);
        }

        #endregion

        #region 学历模块

        /// <summary>
        /// 查询所有学历类型
        /// </summary>
        /// <returns></returns>
        public List<Education> SelectEducationAll()
        {
            return new BaseService().SelectEducationAll();
        }

        /// <summary>
        /// 查询学历类型
        /// </summary>
        /// <returns></returns>
        public Education SelectEducation(Education education)
        {
            return new BaseService().SelectEducation(education);
        }

        /// <summary>
        /// 添加学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public int AddEducation(Education education)
        {
            return new BaseService().AddEducation(education);
        }

        /// <summary>
        /// 删除学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public int DelEducation(Education education)
        {
            return new BaseService().DelEducation(education);
        }

        /// <summary>
        /// 更新学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public int UpdEducation(Education education)
        {
            return new BaseService().UpdEducation(education);
        }

        #endregion

        #region 部门模块

        /// <summary>
        /// 查询所有部门类型
        /// </summary>
        /// <returns></returns>
        public List<Dept> SelectDeptAll()
        {
            return new BaseService().SelectDeptAll();
        }

        /// <summary>
        /// 查询部门类型
        /// </summary>
        /// <returns></returns>
        public Dept SelectDept(Dept dept)
        {
            return new BaseService().SelectDept(dept);
        }

        /// <summary>
        /// 添加部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int AddDept(Dept dept)
        {
            return new BaseService().AddDept(dept);
        }

        /// <summary>
        /// 删除部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int DelDept(Dept dept)
        {
            return new BaseService().DelDept(dept);
        }

        /// <summary>
        /// 更新部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int UpdDept(Dept dept)
        {
            return new BaseService().UpdDept(dept);
        }

        #endregion
    }
}
