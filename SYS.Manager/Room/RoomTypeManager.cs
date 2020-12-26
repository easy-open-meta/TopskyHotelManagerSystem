using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class RoomTypeManager
    {
        #region 获取所有房间类型
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        public static List<RoomType> SelectRoomTypesAll()
        {
            return RoomTypeService.SelectRoomTypesAll();
        }
        #endregion

        #region 根据房间编号查询房间类型名称
        /// <summary>
        /// 根据房间编号查询房间类型名称
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public static RoomType SelectRoomTypeByRoomNo(string no)
        {
            return RoomTypeService.SelectRoomTypeByRoomNo(no);
        }
        #endregion
    }
}
