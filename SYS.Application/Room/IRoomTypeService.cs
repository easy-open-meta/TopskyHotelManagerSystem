using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 客房信息接口
    /// </summary>
    public interface IRoomTypeService
    {
        #region 获取所有房间类型
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        List<RoomType> SelectRoomTypesAll();
        #endregion

        #region 根据房间编号查询房间类型名称
        /// <summary>
        /// 根据房间编号查询房间类型名称
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        RoomType SelectRoomTypeByRoomNo(string no);
        #endregion
    }
}