using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 资产信息接口
    /// </summary>
    public interface ICashService
    {
        /// <summary>
        /// 添加资产信息
        /// </summary>
        /// <param name="cash"></param>
        /// <returns></returns>
        bool AddCashInfo(Cash cash);

        /// <summary>
        /// 查询资产信息
        /// </summary>
        /// <returns></returns>
        List<Cash> SelectCashInfoAll();
    }
}