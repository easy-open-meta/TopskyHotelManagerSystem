using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 资产信息接口实现类
    /// </summary>
    public class CashService:Repository<Cash>, ICashService
    {
        /// <summary>
        /// 添加资产信息
        /// </summary>
        /// <param name="cash"></param>
        /// <returns></returns>
        public bool AddCashInfo(Cash cash)
        {
            return base.Insert(cash);
        }

        /// <summary>
        /// 查询资产信息
        /// </summary>
        /// <returns></returns>
        public List<Cash> SelectCashInfoAll()
        {
            //查询所有部门信息
            List<Dept> depts = new List<Dept>();
            depts = base.Change<Dept>().GetList(a => a.delete_mk != 1);
            //查询所有员工信息
            List<Worker> workers = new List<Worker>();
            workers = base.Change<Worker>().GetList(a => a.delete_mk != 1);
            List<Cash> cs = new List<Cash>();
            cs = base.GetList(a => a.delete_mk != 1);
            cs.ForEach(source =>
            {
                var dept = depts.FirstOrDefault(a => a.dept_no.Equals(source.CashClub));
                source.DeptName = dept == null ? "" : dept.dept_name;
                var worker = workers.FirstOrDefault(a => a.WorkerId.Equals(source.CashPerson));
                source.PersonName = worker == null ? "" : worker.WorkerName;
            });
            return cs;
        }
    }
}
