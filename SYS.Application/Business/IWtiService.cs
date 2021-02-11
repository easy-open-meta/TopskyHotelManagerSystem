using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 水电信息接口
    /// </summary>
    public interface IWtiService
    {
        #region 根据房间编号查询水电费信息
        /// <summary>
        /// 根据房间编号查询水电费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <returns></returns>
        Wti SelectWtiInfoByRoomNo(string roomNo);
        #endregion

        #region 根据房间编号、使用时间查询水电费信息
        /// <summary>
        /// 根据房间编号、使用时间查询水电费信息
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="usedate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        Wti SelectWtiInfoByRoomNoAndTime(string roomno, string usedate, string enddate);
        #endregion

        #region 获取所有水电费信息
        /// <summary>
        /// 获取所有水电费信息
        /// </summary>
        /// <returns></returns>
        List<Wti> SelectWtiInfoAll();
        #endregion

        #region 添加水电费信息
        /// <summary>
        /// 添加水电费信息
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        bool InsertWtiInfo(Wti w);
        #endregion

        #region 修改水电费信息(根据房间编号)
        /// <summary>
        /// 修改水电费信息(根据房间编号)
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        bool UpdateWtiInfo(Wti w);
        #endregion

        #region 根据房间信息、使用时间修改水电费
        /// <summary>
        /// 根据房间信息、使用时间修改水电费
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        bool UpdateWtiInfoByRoomNoAndDateTime(Wti w);
        #endregion

        #region 删除水电费信息:根据房间编号
        /// <summary>
        /// 删除水电费信息:根据房间编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        bool DeleteWtiInfo(string roomno);
        #endregion

        #region 根据房间编号、使用时间删除水电费信息
        /// <summary>
        /// 根据房间编号、使用时间删除水电费信息
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="usedate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        bool DeleteWtiInfoByRoomNoAndDateTime(string roomno, string usedate, string enddate);
        #endregion
    }
}