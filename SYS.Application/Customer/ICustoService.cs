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
        /// 更新客户信息
        /// </summary>
        /// <param name="custo"></param>
        /// <returns></returns>
        bool UpdCustomerInfoByCustoNo(Custo custo);

        /// <summary>
        /// 更新客户类型(即会员等级)
        /// </summary>
        /// <param name="custoNo"></param>
        /// <param name="userType"></param>
        /// <returns></returns>
        bool UpdCustomerTypeByCustoNo(string custoNo, int userType);

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
        /// 查询指定客户信息
        /// </summary>
        /// <returns></returns>
        List<Custo> SelectCustoByInfo(Custo custo);

        /// <summary>
        /// 根据客户编号查询客户信息
        /// </summary>
        /// <param name="CustoNo"></param>
        /// <returns></returns>
        Custo SelectCardInfoByCustoNo(string CustoNo);


    }
}