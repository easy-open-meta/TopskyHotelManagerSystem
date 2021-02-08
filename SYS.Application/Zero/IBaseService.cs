using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 基础信息接口
    /// </summary>
    public interface IBaseService
    {
        #region 性别模块

        /// <summary>
        /// 查询所有性别类型
        /// </summary>
        /// <returns></returns>
        List<SexType> SelectSexTypeAll();

        /// <summary>
        /// 查询性别类型
        /// </summary>
        /// <returns></returns>
        SexType SelectSexType(SexType sexType);

        /// <summary>
        /// 添加性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        int AddSexType(SexType sexType);

        /// <summary>
        /// 删除性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        int DelSexType(SexType sexType);

        /// <summary>
        /// 更新性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        int UpdSexType(SexType sexType);

        #endregion

        #region 职位模块

        /// <summary>
        /// 查询所有职位类型
        /// </summary>
        /// <returns></returns>
        List<Position> SelectPositionAll();

        /// <summary>
        /// 查询职位类型
        /// </summary>
        /// <returns></returns>
        Position SelectPosition(Position position);

        /// <summary>
        /// 添加职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        int AddPosition(Position position);

        /// <summary>
        /// 删除职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        int DelPosition(Position position);

        /// <summary>
        /// 更新职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        int UpdPosition(Position position);

        #endregion

        #region 民族模块

        /// <summary>
        /// 查询所有民族类型
        /// </summary>
        /// <returns></returns>
        List<Nation> SelectNationAll();

        /// <summary>
        /// 查询民族类型
        /// </summary>
        /// <returns></returns>
        Nation SelectNation(Nation nation);

        /// <summary>
        /// 添加民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        int AddNation(Nation nation);

        /// <summary>
        /// 删除民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        int DelNation(Nation nation);

        /// <summary>
        /// 更新民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        int UpdNation(Nation nation);

        #endregion

        #region 学历模块

        /// <summary>
        /// 查询所有学历类型
        /// </summary>
        /// <returns></returns>
        List<Education> SelectEducationAll();

        /// <summary>
        /// 查询学历类型
        /// </summary>
        /// <returns></returns>
        Education SelectEducation(Education education);

        /// <summary>
        /// 添加学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        int AddEducation(Education education);

        /// <summary>
        /// 删除学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        int DelEducation(Education education);

        /// <summary>
        /// 更新学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        int UpdEducation(Education education);

        #endregion

        #region 部门模块

        /// <summary>
        /// 查询所有部门类型
        /// </summary>
        /// <returns></returns>
        List<Dept> SelectDeptAll();

        /// <summary>
        /// 查询部门类型
        /// </summary>
        /// <returns></returns>
        Dept SelectDept(Dept dept);

        /// <summary>
        /// 添加部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        int AddDept(Dept dept);

        /// <summary>
        /// 删除部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        int DelDept(Dept dept);

        /// <summary>
        /// 更新部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        int UpdDept(Dept dept);

        #endregion
    }
}
