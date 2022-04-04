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

                source.CashPriceStr = source.CashPrice == 0 ? "" : Decimal.Parse(source.CashPrice.ToString()).ToString("#,##0.00").ToString();

            });
            return cs;
        }
    }
}
