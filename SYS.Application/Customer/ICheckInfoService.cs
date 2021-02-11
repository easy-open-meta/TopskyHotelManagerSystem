using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 监管统计接口
    /// </summary>
    public interface ICheckInfoService
    {
        /// <summary>
        /// 查询所有监管统计信息
        /// </summary>
        /// <returns></returns>
        List<CheckInfo> SelectCheckInfoAll();
    }
}