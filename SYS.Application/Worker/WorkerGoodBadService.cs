using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYS.Core;
using SYS.Common;

namespace SYS.Application
{
    /// <summary>
    /// 员工奖惩记录接口实现类
    /// </summary>
    public class WorkerGoodBadService:Repository<WorkerGoodBad>, IWorkerGoodBadService
    {
        /// <summary>
        /// 添加员工奖惩记录
        /// </summary>
        /// <param name="goodBad"></param>
        /// <returns></returns>
        public bool AddGoodBad(WorkerGoodBad goodBad)
        {
            return base.Insert(goodBad);
        }

        /// <summary>
        /// 根据工号查找所有的奖惩记录信息
        /// </summary>
        /// <param name="wn"></param>
        /// <returns></returns>
        public List<WorkerGoodBad> SelectAllGoodBadByWorkNo(string wn) 
        {
            List<GBType> gBTypes = new List<GBType>();
            gBTypes = base.Change<GBType>().GetList(a => a.delete_mk != 1);
            List<WorkerGoodBad> gb = new List<WorkerGoodBad>();
            gb = base.GetList(a => a.WorkNo == wn);
            gb.ForEach(source =>
            {
                var gbType = gBTypes.FirstOrDefault(a => a.GBTypeId == source.GBType);
                source.TypeName = string.IsNullOrEmpty(gbType.GBName) ? "" : gbType.GBName;
            });
            return gb;
        }
    }
}
