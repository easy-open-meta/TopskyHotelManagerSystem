using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 水电信息接口实现类
    /// </summary>
    public class WtiService:Repository<Wti>, IWtiService
    {
        #region 根据房间编号查询水电费信息
        /// <summary>
        /// 根据房间编号查询水电费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <returns></returns>
        public Wti SelectWtiInfoByRoomNo(string roomNo)
        {
            Wti w = new Wti();
            w = base.GetSingle(a => a.RoomNo.Contains(roomNo) && a.delete_mk != 1);
            return w;
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
        public Wti SelectWtiInfoByRoomNoAndTime(string roomno, string usedate, string enddate)
        {
            Wti w = null;
            string sql = "select * from WTINFO where RoomNo='" + roomno +
                "' and UseDate='" + usedate + "' and EndDate='" + enddate + "'";
            w = base.GetSingle(a => a.RoomNo == roomno && a.UseDate >= Convert.ToDateTime(usedate) && a.EndDate >= Convert.ToDateTime(enddate));
            return w;
        }
        #endregion

        #region 获取所有水电费信息
        /// <summary>
        /// 获取所有水电费信息
        /// </summary>
        /// <returns></returns>
        public List<Wti> SelectWtiInfoAll()
        {
            List<Wti> wti = new List<Wti>();
            wti = base.GetList(a => a.delete_mk != 1);
            return wti;
        }
        #endregion

        #region 添加水电费信息
        /// <summary>
        /// 添加水电费信息
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public bool InsertWtiInfo(Wti w)
        {
            return base.Insert(w);
        }
        #endregion

        #region 修改水电费信息(根据房间编号)
        /// <summary>
        /// 修改水电费信息(根据房间编号)
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public bool UpdateWtiInfo(Wti w)
        {
            return base.Update(a => new Wti()
            {
                UseDate = w.UseDate,
                EndDate = w.EndDate,
                WaterUse = w.WaterUse,
                PowerUse = w.PowerUse,
                Record = w.Record,
                CustoNo = w.CustoNo
            },a => a.RoomNo == w.RoomNo);

        }
        #endregion

        #region 根据房间信息、使用时间修改水电费
        /// <summary>
        /// 根据房间信息、使用时间修改水电费
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public bool UpdateWtiInfoByRoomNoAndDateTime(Wti w)
        {
            return base.Update(a => new Wti()
            {
                WaterUse = w.WaterUse,
                PowerUse = w.PowerUse,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now,
            },a => a.RoomNo == w.RoomNo && a.UseDate >= w.UseDate && a.EndDate >= w.EndDate);
        }
        #endregion

        #region 删除水电费信息:根据房间编号
        /// <summary>
        /// 删除水电费信息:根据房间编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        public bool DeleteWtiInfo(string roomno)
        {
            return base.Update(a => new Wti()
            {
                delete_mk = 1,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => a.WtiNo == roomno);
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
        public bool DeleteWtiInfoByRoomNoAndDateTime(string roomno, string usedate, string enddate)
        {
            string sql = "delete from WTINFO where RoomNo='{0}' and UseDate='{1}' and EndDate='{2}'";
            sql = string.Format(sql, roomno, usedate, enddate);
            return base.Update(a => new Wti()
            {
                delete_mk = 1,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.RoomNo == roomno && a.UseDate >= Convert.ToDateTime(usedate) && a.EndDate >= Convert.ToDateTime(enddate));
        }
        #endregion
    }
}
