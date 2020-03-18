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
    public class WtiManager
    {
        #region 根据房间编号查询水电费信息
        /// <summary>
        /// 根据房间编号查询水电费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <returns></returns>
        public static Wti SelectWtiInfoByRoomNo(string roomNo)
        {
            return WtiService.SelectWtiInfoByRoomNo(roomNo);
        }
        #endregion

        #region 根据房间编号、使用时间查询水电费信息
        /// <summary>
        /// 根据房间编号、使用时间查询水电费信息
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="usedate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        public static Wti SelectWtiInfoByRoomNoAndTime(string roomno, string usedate, string enddate)
        {
            return WtiService.SelectWtiInfoByRoomNoAndTime(roomno, usedate, enddate);
        }
        #endregion

        #region 获取所有水电费信息
        /// <summary>
        /// 获取所有水电费信息
        /// </summary>
        /// <returns></returns>
        public static List<Wti> SelectWtiInfoAll()
        {
            return WtiService.SelectWtiInfoAll();
        }
        #endregion

        #region 添加水电费信息
        /// <summary>
        /// 添加水电费信息
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int InsertWtiInfo(Wti w)
        {
            return WtiService.InsertWtiInfo(w);
        }
        #endregion

        #region 修改水电费信息(根据房间编号)
        /// <summary>
        /// 修改水电费信息(根据房间编号)
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int UpdateWtiInfo(Wti w)
        {
            return WtiService.UpdateWtiInfo(w);
        }
        #endregion

        #region 根据房间信息、使用时间修改水电费
        /// <summary>
        /// 根据房间信息、使用时间修改水电费
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int UpdateWtiInfoByRoomNoAndDateTime(Wti w)
        {
            return WtiService.UpdateWtiInfoByRoomNoAndDateTime(w);
        }
        #endregion

        #region 删除水电费信息:根据房间编号
        /// <summary>
        /// 删除水电费信息:根据房间编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public static int DeleteWtiInfo(string roomno)
        {
            return WtiService.DeleteWtiInfo(roomno);
        }
        #endregion

        #region 根据房间编号、使用时间删除水电费信息
        /// <summary>
        /// 根据房间编号、使用时间删除水电费信息
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="usedate"></param>
        /// <param name="enddate"></param>
        /// <returns></returns>
        public static int DeleteWtiInfoByRoomNoAndDateTime(string roomno, string usedate, string enddate)
        {
            return WtiService.DeleteWtiInfoByRoomNoAndDateTime(roomno, usedate, enddate);
        }
        #endregion
    }
}
