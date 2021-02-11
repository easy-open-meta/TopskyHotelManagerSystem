using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 房间信息接口
    /// </summary>
    public interface IRoomService
    {
        #region 根据房间状态获取相应状态的房间信息
        /// <summary>
        /// 根据房间状态获取相应状态的房间信息
        /// </summary>
        /// <param name="stateid"></param>
        /// <returns></returns>
        List<Room> SelectRoomByRoomState(int stateid);
        #endregion


        #region 根据房间状态来查询可使用的房间
        /// <summary>
        /// 根据房间状态来查询可使用的房间
        /// </summary>
        /// <returns></returns>
        List<Room> SelectCanUseRoomAll();
        #endregion


        #region 获取所有房间信息
        /// <summary>
        /// 获取所有房间信息
        /// </summary>
        /// <returns></returns>
        List<Room> SelectRoomAll();
        #endregion

        #region 获取房间分区的信息
        /// <summary>
        /// 获取房间分区的信息
        /// </summary>
        /// <returns></returns>
        List<Room> SelectRoomByTypeName(string TypeName);
        #endregion

        #region 根据房间编号查询房间信息
        /// <summary>
        /// 根据房间编号查询房间信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        Room SelectRoomByRoomNo(string no);
        #endregion

        #region 根据房间编号退房（退房）
        /// <summary>
        /// 根据房间编号退房（退房）
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        bool UpdateRoomByRoomNo(string room);
        #endregion

        #region 根据房间编号查询截止到今天住了多少天
        /// <summary>
        /// 根据房间编号查询截止到今天住了多少天
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        object DayByRoomNo(string roomno);
        #endregion

        #region 根据房间编号修改房间信息（入住）
        /// <summary>
        /// 根据房间编号修改房间信息（入住）
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        bool UpdateRoomInfo(Room r);
        #endregion

        #region 根据房间编号修改房间信息（预约）
        /// <summary>
        /// 根据房间编号修改房间信息（预约）
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        bool UpdateRoomInfoWithReser(Room r);
        #endregion

        #region 查询可入住房间数量
        /// <summary>
        /// 查询可入住房间数量
        /// </summary>
        /// <returns></returns>
        object SelectCanUseRoomAllByRoomState();
        #endregion

        #region 查询已入住房间数量
        /// <summary>
        /// 查询已入住房间数量
        /// </summary>
        /// <returns></returns>
        object SelectNotUseRoomAllByRoomState();
        #endregion

        #region 根据房间编号查询房间价格
        /// <summary>
        /// 根据房间编号查询房间价格
        /// </summary>
        /// <returns></returns>
        object SelectRoomByRoomPrice(string r);
        #endregion

        #region 查询脏房数量
        /// <summary>
        /// 查询脏房数量
        /// </summary>
        /// <returns></returns>
        object SelectNotClearRoomAllByRoomState();
        #endregion

        #region 查询维修房数量
        /// <summary>
        /// 查询维修房数量
        /// </summary>
        /// <returns></returns>
        object SelectFixingRoomAllByRoomState();
        #endregion

        #region 查询预约房数量
        /// <summary>
        /// 查询预约房数量
        /// </summary>
        /// <returns></returns>
        object SelectReseredRoomAllByRoomState();
        #endregion

        #region 根据房间编号更改房间状态
        /// <summary>
        /// 根据房间编号更改房间状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="stateid"></param>
        /// <returns></returns>
        bool UpdateRoomStateByRoomNo(string roomno, int stateid);
        #endregion

        #region 添加房间
        /// <summary>
        /// 添加房间
        /// </summary>
        /// <param name="rn"></param>
        /// <returns></returns>
        bool InsertRoom(Room rn);
        #endregion

        #region 查询所有可消费（已住）房间
        /// <summary>
        /// 查询所有可消费（已住）房间
        /// </summary>
        /// <returns></returns>
        List<Room> SelectRoomByStateAll();
        #endregion

        #region 获取所有房间状态
        /// <summary>
        /// 获取所有房间状态
        /// </summary>
        /// <returns></returns>
        List<RoomState> SelectRoomStateAll();
        #endregion

        #region 根据房间编号查询房间状态编号
        /// <summary>
        /// 根据房间编号查询房间状态编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        object SelectRoomStateIdByRoomNo(string roomno);
        #endregion
    }
}