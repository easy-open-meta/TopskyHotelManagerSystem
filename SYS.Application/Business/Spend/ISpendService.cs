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
    /// 消费信息接口
    /// </summary>
    public interface ISpendService
    {
        #region 添加消费信息
        /// <summary>
        /// 添加消费信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        bool InsertSpendInfo(Spend s);
        #endregion

        #region 根据客户编号查询消费信息
        /// <summary>
        /// 根据客户编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        List<Spend> SelectSpendByCustoNo(string No);
        #endregion

        #region 根据房间编号查询消费信息
        /// <summary>
        /// 根据房间编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        List<Spend> SelectSpendByRoomNo(string No);
        #endregion

        #region 根据客户编号查询历史消费信息
        /// <summary>
        /// 根据客户编号查询历史消费信息
        /// </summary>
        /// <param name="custoNo"></param>
        /// <returns></returns>
        List<Spend> SeletHistorySpendInfoAll(string custoNo);
        #endregion

        #region 查询消费的所有信息
        /// <summary>
        /// 查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        List<Spend> SelectSpendInfoAll();
        #endregion

        #region 根据房间号查询消费的所有信息
        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        List<Spend> SelectSpendInfoRoomNo(string RoomNo);
        #endregion

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="custono"></param>
        /// <returns></returns>
        object SelectMoneyByRoomNoAndTime(string roomno, string custono);
        #endregion

        #region 根据房间编号、入住时间和当前时间修改结算状态
        /// <summary>
        /// 根据房间编号、入住时间和当前时间修改结算状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="checktime"></param>
        /// <returns></returns>
        bool UpdateMoneyState(string roomno, string checktime);
        #endregion

        #region 将转房前的未结算记录一同转移到新房间
        /// <summary>
        /// 将转房前的未结算记录一同转移到新房间
        /// </summary>
        /// <param name="spends"></param>
        /// <param name="newRoom"></param>
        /// <param name="custoNo"></param>
        /// <returns></returns>
        bool UpdateSpendInfoByRoomNo(List<Spend> spends, string newRoom, string custoNo);
        #endregion

        /// <summary>
        /// 更新消费信息
        /// </summary>
        /// <param name="spend"></param>
        /// <returns></returns>
        bool UpdSpenInfo(Spend spend);
    }
}