/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
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
        /// 查询所有性别类型(可用)
        /// </summary>
        /// <returns></returns>
        List<SexType> SelectSexTypeAllCanUse();

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
        /// 查询所有职位类型(可用)
        /// </summary>
        /// <returns></returns>
        List<Position> SelectPositionAllCanUse();

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
        /// 查询所有民族类型(可用)
        /// </summary>
        /// <returns></returns>
        List<Nation> SelectNationAllCanUse();

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
        /// 查询所有学历类型(可用)
        /// </summary>
        /// <returns></returns>
        List<Education> SelectEducationAllCanUse();

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
        /// 查询所有部门类型(可用)
        /// </summary>
        /// <returns></returns>
        List<Dept> SelectDeptAllCanUse();

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

        #region 客户类型模块

        /// <summary>
        /// 查询所有客户类型(可用)
        /// </summary>
        /// <returns></returns>
        List<CustoType> SelectCustoTypeAllCanUse();

        /// <summary>
        /// 查询所有客户类型
        /// </summary>
        /// <returns></returns>
        List<CustoType> SelectCustoTypeAll();

        /// <summary>
        /// 根据客户类型ID查询类型名称
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        CustoType SelectCustoTypeByTypeId(CustoType custoType);

        /// <summary>
        /// 添加客户类型
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        bool InsertCustoType(CustoType custoType);

        /// <summary>
        /// 删除客户类型
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
         bool DeleteCustoType(CustoType custoType);

        /// <summary>
        /// 更新客户类型
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        bool UpdateCustoType(CustoType custoType);

        #endregion

        #region 证件类型模块

        /// <summary>
        /// 查询所有证件类型(可用)
        /// </summary>
        /// <returns></returns>
        List<PassPortType> SelectPassPortTypeAllCanUse();

        /// <summary>
        /// 查询所有证件类型
        /// </summary>
        /// <returns></returns>
        List<PassPortType> SelectPassPortTypeAll();

        /// <summary>
        /// 根据证件类型ID查询类型名称
        /// </summary>
        /// <param name="passPortType"></param>
        /// <returns></returns>
        PassPortType SelectPassPortTypeByTypeId(PassPortType passPortType);

        /// <summary>
        /// 添加证件类型
        /// </summary>
        /// <param name="passPortType"></param>
        /// <returns></returns>
        bool InsertPassPortType(PassPortType passPortType);

        /// <summary>
        /// 删除证件类型
        /// </summary>
        /// <param name="portType"></param>
        /// <returns></returns>
        bool DeletePassPortType(PassPortType portType);

        /// <summary>
        /// 更新证件类型
        /// </summary>
        /// <param name="portType"></param>
        /// <returns></returns>
        bool UpdatePassPortType(PassPortType portType);

        #endregion

        #region 奖惩类型模块

        /// <summary>
        /// 查询所有证件类型(可用)
        /// </summary>
        /// <returns></returns>
        List<GBType> SelectGBTypeAllCanUse();

        /// <summary>
        /// 查询所有奖惩类型
        /// </summary>
        /// <returns></returns>
        List<GBType> SelectGBTypeAll();

        /// <summary>
        /// 根据奖惩类型ID查询类型名称
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        GBType SelectGBTypeByTypeId(GBType gBType);

        /// <summary>
        /// 添加奖惩类型
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        bool InsertGBType(GBType gBType);

        /// <summary>
        /// 删除奖惩类型
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        bool DeleteGBType(GBType gBType);

        /// <summary>
        /// 更新奖惩类型
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        bool UpdateGBType(GBType gBType);

        #endregion

        #region URL模块
        /// <summary>
        /// 基础URL
        /// </summary>
        /// <returns></returns>
        Base GetBase();
        #endregion
    }
}
