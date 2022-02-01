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
using System;
using System.Collections.Generic;
using System.Linq;
using EncryptTools;
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
        Encrypt encrypt = new Encrypt();
        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool UpdateWorker(Worker worker)
        {
            //加密联系方式
            var sourceTelStr =string.Empty;
            if (!string.IsNullOrEmpty(worker.WorkerTel))
            {
                sourceTelStr = encrypt.Encryption(worker.WorkerTel);
            }
            //加密身份证
            var sourceIdStr = string.Empty;
            if (!string.IsNullOrEmpty(worker.CardId))
            {
                 sourceIdStr = encrypt.Encryption(worker.CardId);
            }
            worker.WorkerTel = sourceTelStr;
            worker.CardId = sourceIdStr;
            return base.Update(a => new Worker()
            {
                WorkerName = worker.WorkerName,
                WorkerTel = worker.WorkerTel,
                WorkerAddress = worker.WorkerAddress,
                WorkerFace = worker.WorkerFace,
                WorkerEducation = worker.WorkerEducation,
                WorkerNation = worker.WorkerNation,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            },a => a.WorkerId.Equals(worker.WorkerId));

        }
        #endregion

        /// <summary>
        /// 员工账号禁/启用
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool ManagerWorkerAccount(Worker worker)
        {
            return new WorkerService().Update(a => new Worker()
            {
                delete_mk = worker.delete_mk
            }, a => a.WorkerId == worker.WorkerId);
        }

        /// <summary>
        /// 更新员工职位和部门
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>

        public bool UpdateWorkerPositionAndClub(Worker worker)
        {
            return base.Update(a => new Worker()
            {
                WorkerClub = worker.WorkerClub,
                WorkerPosition = worker.WorkerPosition,
                datachg_usr = AdminInfo.Account,
                datachg_date = DateTime.Now
            }, a => a.WorkerId == worker.WorkerId);
        }

        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool AddWorker(Worker worker)
        {
            string NewID = encrypt.Encryption(worker.CardId);
            string NewTel = encrypt.Encryption(worker.WorkerTel);
            worker.CardId = NewID;
            worker.WorkerTel = NewTel;
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
            workers = base.Change<Worker>().GetList();
            workers.ForEach(source =>
            {
                //解密身份证号码
                var sourceStr = source.CardId.Contains("·") ? encrypt.Decryption(source.CardId) : source.CardId;
                source.CardId = sourceStr;
                //解密联系方式
                var sourceTelStr = source.WorkerTel.Contains("·") ? encrypt.Decryption(source.WorkerTel) : source.WorkerTel;
                source.WorkerTel = sourceTelStr;
                //性别类型
                var sexType = sexTypes.FirstOrDefault(a => a.sexId == source.WorkerSex);
                source.WorkerSexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
                //教育程度
                var eduction = educations.FirstOrDefault(a => a.education_no == source.WorkerEducation);
                source.EducationName = string.IsNullOrEmpty(eduction.education_name) ? "" : eduction.education_name;
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
            //解密身份证号码
            var sourceStr = w.CardId.Contains("·") ? encrypt.Decryption(w.CardId) : w.CardId;
            w.CardId = sourceStr;
            //解密联系方式
            var sourceTelStr = w.WorkerTel.Contains("·") ? encrypt.Decryption(w.WorkerTel) : w.WorkerTel;
            w.WorkerTel = sourceTelStr;
            //性别类型
            var sexType = base.Change<SexType>().GetSingle(a => a.sexId == w.WorkerSex);
            w.WorkerSexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
            //教育程度
            var eduction = base.Change<Education>().GetSingle(a => a.education_no == w.WorkerEducation);
            w.EducationName = string.IsNullOrEmpty(eduction.education_name) ? "" : eduction.education_name;
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
        /// <param name="worker"></param>
        /// <returns></returns>
        public Worker SelectWorkerInfoByWorkerIdAndWorkerPwd(Worker worker)
        {
            Worker w = new Worker();
            w = base.GetSingle(a => a.WorkerId == worker.WorkerId);
            if (w == null)
            {
                w = null;
                return w;
            }

            var sourceStr = w.WorkerPwd.Contains("·") ? encrypt.Decryption(w.WorkerPwd) : w.WorkerPwd;
            if (sourceStr != worker.WorkerPwd)
            {
                w = null;
                return w;
            }

            //性别类型
            var sexType = base.Change<SexType>().GetSingle(a => a.sexId == w.WorkerSex);
            w.WorkerSexName = string.IsNullOrEmpty(sexType.sexName) ? "" : sexType.sexName;
            //教育程度
            var eduction = base.Change<Education>().GetSingle(a => a.education_no == w.WorkerEducation);
            w.EducationName = string.IsNullOrEmpty(eduction.education_name) ? "" : eduction.education_name;
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

        /// <summary>
        /// 根据员工编号和密码修改密码
        /// </summary>
        /// <param name="workId"></param>
        /// <param name="workPwd"></param>
        /// <returns></returns>
        public bool UpdWorkerPwdByWorkNo(string workId,string workPwd)
        {
            string NewPwd = encrypt.Decryption(workPwd);
            return base.Update(a => new Worker()
            {
                WorkerPwd = NewPwd,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.WorkerId == workId);
        }

    }
}
