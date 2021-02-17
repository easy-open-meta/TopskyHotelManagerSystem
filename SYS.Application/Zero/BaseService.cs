using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 基础信息接口实现类
    /// </summary>
    public class BaseService: Repository<SexType>,IBaseService
    {

        #region 性别模块

        /// <summary>
        /// 查询所有性别类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<SexType> SelectSexTypeAllCanUse()
        {
            List<SexType> sexTypes = new List<SexType>();
            sexTypes = base.GetList(a => a.delete_mk != 1);
            return sexTypes;
        }

        /// <summary>
        /// 查询所有性别类型
        /// </summary>
        /// <returns></returns>
        public List<SexType> SelectSexTypeAll()
        {
            List<SexType> sexTypes = new List<SexType>();
            sexTypes = base.GetList();
            return sexTypes;
        }

        /// <summary>
        /// 查询性别类型
        /// </summary>
        /// <returns></returns>
        public SexType SelectSexType(SexType sexType)
        {
            SexType sexTypes = new SexType();
            sexTypes = base.GetSingle(a => a.sexId == sexType.sexId);
            return sexTypes;
        }

        /// <summary>
        /// 添加性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public bool AddSexType(SexType sexType)
        {
            return base.Insert(sexType);
        }

        /// <summary>
        /// 删除性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public bool DelSexType(SexType sexType)
        {
            return base.Update(a => new SexType()
            {
                delete_mk = sexType.delete_mk,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.sexId == sexType.sexId);
        }

        /// <summary>
        /// 更新性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public bool UpdSexType(SexType sexType)
        {
            return base.Update(a => new SexType()
            {
                sexName = sexType.sexName,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.sexId == sexType.sexId);
        }

        #endregion

        #region 职位模块

        /// <summary>
        /// 查询所有职位类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<Position> SelectPositionAllCanUse()
        {
            List<Position> positions = new List<Position>();
            positions = base.Change<Position>().GetList(a => a.delete_mk != 1);
            return positions;
        }

        /// <summary>
        /// 查询所有职位类型
        /// </summary>
        /// <returns></returns>
        public List<Position> SelectPositionAll()
        {
            List<Position> positions = new List<Position>();
            positions = base.Change<Position>().GetList();
            return positions;
        }

        /// <summary>
        /// 查询职位类型
        /// </summary>
        /// <returns></returns>
        public Position SelectPosition(Position position)
        {
            Position position1 = new Position();
            position1 = base.Change<Position>().GetSingle(a => a.position_no == position.position_no);
            return position1;
        }

        /// <summary>
        /// 添加职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool AddPosition(Position position)
        {
            return base.Change<Position>().Insert(position);
        }

        /// <summary>
        /// 删除职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool DelPosition(Position position)
        {
            return base.Change<Position>().Update(a => new Position()
            {
                delete_mk = position.delete_mk,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.position_no == position.position_no);
        }

        /// <summary>
        /// 更新职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool UpdPosition(Position position)
        {
            return base.Change<Position>().Update(a => new Position()
            {
                position_name = position.position_name,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.position_no == position.position_no);
        }

        #endregion

        #region 民族模块

        /// <summary>
        /// 查询所有民族类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<Nation> SelectNationAllCanUse()
        {
            List<Nation> nations = new List<Nation>();
            nations = base.Change<Nation>().GetList(a => a.delete_mk != 1);
            return nations;
        }

        /// <summary>
        /// 查询所有民族类型
        /// </summary>
        /// <returns></returns>
        public List<Nation> SelectNationAll()
        {
            List<Nation> nations = new List<Nation>();
            nations = base.Change<Nation>().GetList();
            return nations;
        }

        /// <summary>
        /// 查询民族类型
        /// </summary>
        /// <returns></returns>
        public Nation SelectNation(Nation nation)
        {
            Nation nation1 = new Nation();
            nation1 = base.Change<Nation>().GetSingle(a => a.nation_no.Equals(nation.nation_no));
            return nation1;
        }

        /// <summary>
        /// 添加民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public bool AddNation(Nation nation)
        {
            return base.Change<Nation>().Insert(nation);
        }

        /// <summary>
        /// 删除民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public bool DelNation(Nation nation)
        {
            return base.Change<Nation>().Update(a => new Nation() 
            {
                delete_mk = nation.delete_mk,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.nation_no.Equals(nation.nation_no));

        }

        /// <summary>
        /// 更新民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public bool UpdNation(Nation nation)
        {
            return base.Change<Nation>().Update(a => new Nation()
            {
                nation_name = nation.nation_name,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.nation_no.Equals(nation.nation_no));
        }

        #endregion

        #region 学历模块

        /// <summary>
        /// 查询所有学历类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<Education> SelectEducationAllCanUse()
        {
            List<Education> educations = new List<Education>();
            educations = base.Change<Education>().GetList(a => a.delete_mk != 1);
            return educations;
        }

        /// <summary>
        /// 查询所有学历类型
        /// </summary>
        /// <returns></returns>
        public List<Education> SelectEducationAll()
        {
            List<Education> educations = new List<Education>();
            educations = base.Change<Education>().GetList();
            return educations;
        }

        /// <summary>
        /// 查询学历类型
        /// </summary>
        /// <returns></returns>
        public Education SelectEducation(Education education)
        {
            Education education1 = new Education();
            education1 = base.Change<Education>().GetSingle(a => a.education_no == education.education_no);
            return education1;
        }

        /// <summary>
        /// 添加学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public bool AddEducation(Education education)
        {
            return base.Change<Education>().Insert(education);
        }

        /// <summary>
        /// 删除学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public bool DelEducation(Education education)
        {
            return base.Change<Education>().Update(a => new Education()
            {
                delete_mk = education.delete_mk,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.education_no == education.education_no);
        }

        /// <summary>
        /// 更新学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public bool UpdEducation(Education education)
        {
            return base.Change<Education>().Update(a => new Education()
            {
                education_name = education.education_name,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.education_no == education.education_no);
        }

        #endregion

        #region 部门模块

        /// <summary>
        /// 查询所有部门类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<Dept> SelectDeptAllCanUse()
        {
            List<Worker> workers = new List<Worker>();
            workers = base.Change<Worker>().GetList(a => a.delete_mk != 1);
            List<Dept> depts = new List<Dept>();
            depts = base.Change<Dept>().GetList(a => a.delete_mk != 1);
            depts.ForEach(source =>
            {
                var dept = depts.FirstOrDefault(a => a.dept_no == source.dept_parent);
                source.parent_name = dept == null ? "" : dept.dept_name;
                var leader = workers.FirstOrDefault(a => source.dept_leader != null && a.WorkerId == source.dept_leader);
                source.leader_name = leader == null ? "" : leader.WorkerName;
            });
            return depts;
        }

        /// <summary>
        /// 查询所有部门类型
        /// </summary>
        /// <returns></returns>
        public List<Dept> SelectDeptAll()
        {
            List<Worker> workers = new List<Worker>();
            workers = base.Change<Worker>().GetList(a => a.delete_mk != 1);
            List<Dept> depts = new List<Dept>();
            depts = base.Change<Dept>().GetList(a => a.delete_mk != 1);
            depts.ForEach(source =>
            {
                var dept = depts.FirstOrDefault(a => a.dept_no == source.dept_parent);
                source.parent_name = dept == null ? "" : dept.dept_name;
                var leader = workers.FirstOrDefault(a => source.dept_leader != null && a.WorkerId == source.dept_leader);
                source.leader_name = leader == null ? "" : leader.WorkerName;
            });
            return depts;
        }

        /// <summary>
        /// 查询部门类型
        /// </summary>
        /// <returns></returns>
        public Dept SelectDept(Dept dept)
        {
            Dept dept1 = new Dept();
            dept1 = base.Change<Dept>().GetSingle(a => a.dept_no.Equals(dept.dept_no));
            return dept1;
        }

        /// <summary>
        /// 添加部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public bool AddDept(Dept dept)
        {
            return base.Change<Dept>().Insert(dept);
        }

        /// <summary>
        /// 删除部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public bool DelDept(Dept dept)
        {
            return base.Change<Dept>().Update(a => new Dept() 
            {
                delete_mk = dept.delete_mk,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.dept_no == dept.dept_no);
        }

        /// <summary>
        /// 更新部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public bool UpdDept(Dept dept)
        {
            return base.Change<Dept>().Update(a => new Dept() 
            {
                dept_name = dept.dept_name,
                dept_desc = dept.dept_desc,
                dept_leader = dept.dept_leader,
                dept_parent = dept.dept_parent,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.dept_no == dept.dept_no);
        }

        #endregion

        #region 客户类型模块

        /// <summary>
        /// 查询所有客户类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<CustoType> SelectCustoTypeAllCanUse()
        {
            List<CustoType> custoTypes = new List<CustoType>();
            custoTypes = base.Change<CustoType>().GetList(a => a.delete_mk != 1);
            return custoTypes;
        }

        /// <summary>
        /// 查询所有客户类型
        /// </summary>
        /// <returns></returns>
        public List<CustoType> SelectCustoTypeAll() 
        {
            List<CustoType> custoTypes = new List<CustoType>();
            custoTypes = base.Change<CustoType>().GetList();
            return custoTypes;
        }

        /// <summary>
        /// 根据客户类型ID查询类型名称
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        public CustoType SelectCustoTypeByTypeId(CustoType custoType)
        {
            CustoType custoTypes = new CustoType();
            custoType = base.Change<CustoType>().GetSingle(a => a.UserType == custoType.UserType && a.delete_mk != 1);
            return custoTypes;
        }

        /// <summary>
        /// 添加客户类型
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        public bool InsertCustoType(CustoType custoType)
        {
            return base.Change<CustoType>().Insert(custoType);
        }

        /// <summary>
        /// 删除客户类型
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        public bool DeleteCustoType(CustoType custoType)
        {
            return base.Change<CustoType>().Update(a => new CustoType()
            {
                delete_mk = 1,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            },a => a.UserType == custoType.UserType);
        }

        /// <summary>
        /// 更新客户类型
        /// </summary>
        /// <param name="custoType"></param>
        /// <returns></returns>
        public bool UpdateCustoType(CustoType custoType)
        {
            return base.Change<CustoType>().Update(a => new CustoType()
            {
                TypeName = custoType.TypeName,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            },a => a.UserType == custoType.UserType);
        }

        #endregion

        #region 证件类型模块

        /// <summary>
        /// 查询所有证件类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<PassPortType> SelectPassPortTypeAllCanUse()
        {
            List<PassPortType> passPortTypes = new List<PassPortType>();
            passPortTypes = base.Change<PassPortType>().GetList(a => a.delete_mk != 1);
            return passPortTypes;
        }

        /// <summary>
        /// 查询所有证件类型
        /// </summary>
        /// <returns></returns>
        public List<PassPortType> SelectPassPortTypeAll()
        {
            List<PassPortType> passPortTypes = new List<PassPortType>();
            passPortTypes = base.Change<PassPortType>().GetList();
            return passPortTypes;
        }

        /// <summary>
        /// 根据证件类型ID查询类型名称
        /// </summary>
        /// <param name="passPortType"></param>
        /// <returns></returns>
        public PassPortType SelectPassPortTypeByTypeId(PassPortType passPortType)
        {
            PassPortType passPortType1 = new PassPortType();
            passPortType1 = base.Change<PassPortType>().GetSingle(a => a.PassportId == passPortType.PassportId && a.delete_mk != 1);
            return passPortType1;
        }

        /// <summary>
        /// 添加证件类型
        /// </summary>
        /// <param name="passPortType"></param>
        /// <returns></returns>
        public bool InsertPassPortType(PassPortType passPortType)
        {
            return base.Change<PassPortType>().Insert(passPortType);
        }

        /// <summary>
        /// 删除证件类型
        /// </summary>
        /// <param name="portType"></param>
        /// <returns></returns>
        public bool DeletePassPortType(PassPortType  portType)
        {
            return base.Change<PassPortType>().Update(a => new PassPortType()
            {
                delete_mk = 1,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.PassportId == portType.PassportId);
        }

        /// <summary>
        /// 更新证件类型
        /// </summary>
        /// <param name="portType"></param>
        /// <returns></returns>
        public bool UpdatePassPortType(PassPortType portType)
        {
            return base.Change<PassPortType>().Update(a => new PassPortType()
            {
                PassportName = portType.PassportName,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.PassportId == portType.PassportId);
        }

        #endregion

        #region 奖惩类型模块

        /// <summary>
        /// 查询所有奖惩类型(可用)
        /// </summary>
        /// <returns></returns>
        public List<GBType> SelectGBTypeAllCanUse()
        {
            List<GBType> gBTypes = new List<GBType>();
            gBTypes = base.Change<GBType>().GetList(a => a.delete_mk != 1);
            return gBTypes;
        }

        /// <summary>
        /// 查询所有奖惩类型
        /// </summary>
        /// <returns></returns>
        public List<GBType> SelectGBTypeAll()
        {
            List<GBType> gBTypes = new List<GBType>();
            gBTypes = base.Change<GBType>().GetList();
            return gBTypes;
        }

        /// <summary>
        /// 根据奖惩类型ID查询类型名称
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        public GBType SelectGBTypeByTypeId(GBType gBType)
        {
            GBType gBType1 = new GBType();
            gBType1 = base.Change<GBType>().GetSingle(a => a.GBTypeId == gBType.GBTypeId && a.delete_mk != 1);
            return gBType1;
        }

        /// <summary>
        /// 添加奖惩类型
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        public bool InsertGBType(GBType  gBType)
        {
            return base.Change<GBType>().Insert(gBType);
        }

        /// <summary>
        /// 删除奖惩类型
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        public bool DeleteGBType(GBType gBType)
        {
            return base.Change<GBType>().Update(a => new GBType()
            {
                delete_mk = 1,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.GBTypeId == gBType.GBTypeId);
        }

        /// <summary>
        /// 更新奖惩类型
        /// </summary>
        /// <param name="gBType"></param>
        /// <returns></returns>
        public bool UpdateGBType(GBType gBType)
        {
            return base.Change<GBType>().Update(a => new GBType()
            {
                GBName = gBType.GBName,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.GBTypeId == gBType.GBTypeId);
        }

        #endregion
    }
}
