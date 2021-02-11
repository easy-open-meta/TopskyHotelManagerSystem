using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 房间类型接口实现类
    /// </summary>
    public class RoomTypeService:Repository<RoomType>, IRoomTypeService
    {
        #region 获取所有房间类型
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        public List<RoomType> SelectRoomTypesAll()
        {
            List<RoomType> types = new List<RoomType>();
            types = base.GetList(a => a.delete_mk != 1);
            return types;
        }
        #endregion

        #region 根据房间编号查询房间类型名称
        /// <summary>
        /// 根据房间编号查询房间类型名称
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public RoomType SelectRoomTypeByRoomNo(string no)
        {
            RoomType roomtype = new RoomType();
            Room room = new Room();
            room = base.Change<Room>().GetSingle(a => a.RoomNo == no && a.delete_mk != 1);
            roomtype.RoomName = base.GetSingle(a => a.Roomtype == room.RoomStateId).RoomName;
            return roomtype;
        }
        #endregion
    }
}
