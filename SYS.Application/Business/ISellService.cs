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
using System;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 商品接口
    /// </summary>
    public interface ISellService
    {
        /// <summary>
        /// 查询所有商品
        /// </summary>
        /// <returns></returns>
        List<SellThing> SelectSellThingAll(SellThing sellThing = null);

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        bool UpdateSellThing(string stock, string sellNo);

        /// <summary>
        /// 修改商品信息
        /// </summary>
        /// <param name="sellThing"></param>
        /// <returns></returns>
        bool UpdateSellthingInfo(SellThing sellThing);

        /// <summary>
        /// 撤回客户消费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <param name="custoNo"></param>
        /// <param name="sellName"></param>
        /// <returns></returns>
        bool DeleteSellThing(string roomNo, string custoNo, string sellName);

        /// <summary>
        /// 根据商品编号删除商品信息
        /// </summary>
        /// <param name="sellNo"></param>
        /// <returns></returns>
        bool DeleteSellThingBySellNo(string sellNo);

        /// <summary>
        /// 根据商品名称和价格查询商品编号
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        SellThing SelectSellThingByNameAndPrice(string name, string price);


        /// <summary>
        /// 根据商品编号查询商品信息
        /// </summary>
        /// <param name="SellNo"></param>
        /// <returns></returns>
        SellThing SelectSellInfoBySellNo(string SellNo);

        #region 添加商品
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        bool InsertSellThing(SellThing st);
        #endregion
    }
}