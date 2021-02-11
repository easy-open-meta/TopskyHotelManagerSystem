using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 客户信息接口
    /// </summary>
    public interface ICustoService
    {
        #region 添加客户信息
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="custo"></param>
        /// <returns></returns>
        bool InsertCustomerInfo(Custo custo);
        #endregion

        /// <summary>
        /// 查询酒店盈利情况
        /// </summary>
        /// <returns></returns>
        List<CustoSpend> SelectAllMoney();

        /// <summary>
        /// 查询所有客户信息
        /// </summary>
        /// <returns></returns>
        List<Custo> SelectCustoAll();

        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <returns></returns>
        Custo SelectCardInfoByCustoNo(string CustoNo);


    }
}