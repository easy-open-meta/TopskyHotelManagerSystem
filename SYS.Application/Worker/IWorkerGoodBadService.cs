using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 员工奖惩信息接口
    /// </summary>
    public interface IWorkerGoodBadService
    {
        /// <summary>
        /// 添加员工奖惩记录
        /// </summary>
        /// <param name="goodBad"></param>
        /// <returns></returns>
        bool AddGoodBad(WorkerGoodBad goodBad);

        /// <summary>
        /// 根据工号查找所有的奖惩记录信息
        /// </summary>
        /// <param name="wn"></param>
        /// <returns></returns>
        List<WorkerGoodBad> SelectAllGoodBadByWorkNo(string wn);
    }
}