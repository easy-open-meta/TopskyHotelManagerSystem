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
        bool AddSexType(SexType sexType);

        /// <summary>
        /// 删除性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        bool DelSexType(SexType sexType);

        /// <summary>
        /// 更新性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        bool UpdSexType(SexType sexType);

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
        bool AddPosition(Position position);

        /// <summary>
        /// 删除职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        bool DelPosition(Position position);

        /// <summary>
        /// 更新职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        bool UpdPosition(Position position);

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
        bool AddNation(Nation nation);

        /// <summary>
        /// 删除民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        bool DelNation(Nation nation);

        /// <summary>
        /// 更新民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        bool UpdNation(Nation nation);

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
        bool AddEducation(Education education);

        /// <summary>
        /// 删除学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        bool DelEducation(Education education);

        /// <summary>
        /// 更新学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        bool UpdEducation(Education education);

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
        bool AddDept(Dept dept);

        /// <summary>
        /// 删除部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        bool DelDept(Dept dept);

        /// <summary>
        /// 更新部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        bool UpdDept(Dept dept);

        #endregion
    }
}
