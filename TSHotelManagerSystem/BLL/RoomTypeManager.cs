using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSHotelManagerSystem.DAL;
using TSHotelManagerSystem.Models;

namespace TSHotelManagerSystem.BLL
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
