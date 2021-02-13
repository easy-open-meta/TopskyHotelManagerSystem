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

    }
}