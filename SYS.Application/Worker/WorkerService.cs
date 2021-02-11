using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 员工信息接口实现类
    /// </summary>
    public class WorkerService:Repository<Worker>,IWorkerService
    {
        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool UpdateWorker(Worker worker)
        {
            return base.Update(a => new Worker()
            {
                WorkerTel = worker.WorkerTel,
                WorkerAddress = worker.WorkerAddress,
                WorkerPwd = worker.WorkerPwd,
                WorkerFace = worker.WorkerFace,
                WorkerEducation = worker.WorkerEducation,
                WorkerSex = worker.WorkerSex,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            },a => a.WorkerId == worker.WorkerId);

        }
        #endregion


        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool AddWorker(Worker worker)
        {
            return base.Insert(worker);
        }
        #endregion

        #region 获取所有工作人员信息
        /// <summary>
        /// 获取所有工作人员信息
        /// </summary>
        /// <returns></returns>
        public List<Worker> SelectWorkerAll()
        {
            //查询所有教育程度信息
            List<Education> educations = new List<Education>();
            educations = base.Change<Education>().GetList(a => a.delete_mk != 1);
            //查询所有性别类型信息
            List<SexType> sexTypes = new List<SexType>();
            sexTypes = base.Change<SexType>().GetList(a => a.delete_mk != 1);
            //查询所有民族类型信息
            List<Nation> nations = new List<Nation>();
            nations = base.Change<Nation>().GetList(a => a.delete_mk != 1);
            //查询所有部门信息
            List<Dept> depts = new List<Dept>();
            depts = base.Change<Dept>().GetList(a => a.delete_mk != 1);
            //查询所有职位信息
            List<Position> positions = new List<Position>();
            positions = base.Change<Position>().GetList(a => a.delete_mk != 1);
            //查询所有员工信息
            List<Worker> workers = new List<Worker>();
            workers = base.Change<Worker>().GetList(a => a.delete_mk != 1);
            workers.ForEach(source =>
            {
                //性别类型
                var sexType = sexTypes.FirstOrDefault(a => a.sexId == source.WorkerSex);
                source.WorkerSexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
                //教育程度
                var eduction = educations.FirstOrDefault(a => a.education_no == source.WorkerEducation);
                source.WorkerEducation = string.IsNullOrEmpty(eduction.education_name) ? "" : eduction.education_name;
                //民族类型
                var nation = nations.FirstOrDefault(a => a.nation_no == source.WorkerNation);
                source.NationName = string.IsNullOrEmpty(nation.nation_name) ? "" : nation.nation_name;
                //部门
                var dept = depts.FirstOrDefault(a => a.dept_no == source.WorkerClub);
                source.ClubName = string.IsNullOrEmpty(dept.dept_name) ? "" : dept.dept_name;
                //职位
                var position = positions.FirstOrDefault(a => a.position_no == source.WorkerPosition);
                source.PositionName = string.IsNullOrEmpty(position.position_name) ? "" : position.position_name;
            });
            
            return workers;
        }
        #endregion

        #region 根据登录名称查询员工信息
        /// <summary>
        /// 根据登录名称查询员工信息
        /// </summary>
        /// <param name="workerId"></param>
        /// <returns></returns>
        public Worker SelectWorkerInfoByWorkerId(string workerId)
        {
            Worker w = new Worker();
            w = base.Change<Worker>().GetSingle(a => a.WorkerId == workerId);
            //性别类型
            var sexType = base.Change<SexType>().GetSingle(a => a.sexId == w.WorkerSex);
            w.WorkerSexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
            //教育程度
            var eduction = base.Change<Education>().GetSingle(a => a.education_no == w.WorkerEducation);
            w.WorkerEducation = string.IsNullOrEmpty(eduction.education_name) ? "" : eduction.education_name;
            //民族类型
            var nation = base.Change<Nation>().GetSingle(a => a.nation_no == w.WorkerNation);
            w.NationName = string.IsNullOrEmpty(nation.nation_name) ? "" : nation.nation_name;
            //部门
            var dept = base.Change<Dept>().GetSingle(a => a.dept_no == w.WorkerClub);
            w.ClubName = string.IsNullOrEmpty(dept.dept_name) ? "" : dept.dept_name;
            //职位
            var position = base.Change<Position>().GetSingle(a => a.position_no == w.WorkerPosition);
            w.PositionName = string.IsNullOrEmpty(position.position_name) ? "" : position.position_name;
            return w;
        }
        #endregion

        #region 根据登录名称、密码查询员工信息
        /// <summary>
        /// 根据登录名称、密码查询员工信息
        /// </summary>
        /// <param name="id"></param>
        /// 登录名称
        /// <param name="pwd"></param>
        /// 登录密码
        /// <returns></returns>
        public Worker SelectWorkerInfoByWorkerIdAndWorkerPwd(string id, string pwd)
        {
            Worker w = new Worker();
            w = base.GetSingle(a => a.WorkerId == id && a.WorkerPwd == pwd);
            //性别类型
            var sexType = base.Change<SexType>().GetSingle(a => a.sexId == w.WorkerSex);
            w.WorkerSexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
            //教育程度
            var eduction = base.Change<Education>().GetSingle(a => a.education_no == w.WorkerEducation);
            w.WorkerEducation = string.IsNullOrEmpty(eduction.education_name) ? "" : eduction.education_name;
            //民族类型
            var nation = base.Change<Nation>().GetSingle(a => a.nation_no == w.WorkerNation);
            w.NationName = string.IsNullOrEmpty(nation.nation_name) ? "" : nation.nation_name;
            //部门
            var dept = base.Change<Dept>().GetSingle(a => a.dept_no == w.WorkerClub);
            w.ClubName = string.IsNullOrEmpty(dept.dept_name) ? "" : dept.dept_name;
            //职位
            var position = base.Change<Position>().GetSingle(a => a.position_no == w.WorkerPosition);
            w.PositionName = string.IsNullOrEmpty(position.position_name) ? "" : position.position_name;
            return w;
        }
        #endregion
    }
}
