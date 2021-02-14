using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 商品消费接口实现类
    /// </summary>
    public class SpendService:Repository<Spend>, ISpendService
    {
        #region 添加消费信息
        /// <summary>
        /// 添加消费信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool InsertSpendInfo(Spend s)
        {
            return base.Insert(s);
        }
        #endregion

        #region 根据客户编号查询消费信息
        /// <summary>
        /// 根据客户编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public List<Spend> SelectSpendByCustoNo(string No)
        {
            List<Spend> ls = new List<Spend>();
            ls = base.GetList(a => a.CustoNo == No && a.MoneyState == "未结算" && a.delete_mk != 1);
            return ls;
        }
        #endregion

        #region 根据房间编号查询消费信息
        /// <summary>
        /// 根据房间编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        public List<Spend> SelectSpendByRoomNo(string No)
        {
            List<Spend> ls = new List<Spend>();
            ls = base.GetList(a => a.RoomNo == No && a.MoneyState == "未结算" && a.delete_mk != 1);
            return ls;
        }
        #endregion

        #region 查询消费的所有信息
        /// <summary>
        /// 查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public List<Spend> SelectSpendInfoAll()
        {
            List<Spend> ls = new List<Spend>();
            ls = base.GetList(a => a.delete_mk != 1);
            return ls;
        }
        #endregion

        #region 根据房间号查询消费的所有信息
        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        public List<Spend> SelectSpendInfoRoomNo(string RoomNo)
        {
            List<Spend> ls = new List<Spend>();
            ls = base.GetList(a => a.RoomNo == RoomNo && a.delete_mk != 1 && a.MoneyState == "未结算");
            return ls;
        }
        #endregion

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="custono"></param>
        /// <returns></returns>
        public object SelectMoneyByRoomNoAndTime(string roomno,string custono)
        {
            return base.GetList(a => a.RoomNo == roomno && a.CustoNo == custono && a.MoneyState == "未结算").Sum(a => a.SpendMoney);
        }
        #endregion

        #region 根据房间编号、入住时间和当前时间修改结算状态
        /// <summary>
        /// 根据房间编号、入住时间和当前时间修改结算状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="checktime"></param>
        /// <returns></returns>
        public bool UpdateMoneyState(string roomno, string checktime)
        {
            return base.Update(a => new Spend()
            {
                MoneyState = "已结算",
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.RoomNo == roomno && a.SpendTime >= Convert.ToDateTime(checktime) && a.SpendTime <= DateTime.Now); 
        }
        #endregion

        #region 将转房前的未结算记录一同转移到新房间
        /// <summary>
        /// 将转房前的未结算记录一同转移到新房间
        /// </summary>
        /// <param name="spends"></param>
        /// <param name="newRoom"></param>
        /// <param name="custoNo"></param>
        /// <returns></returns>
        public bool UpdateSpendInfoByRoomNo(List<Spend> spends, string newRoom, string custoNo)
        {
            var listSpendId = spends.Select(a => a.SpendName).Distinct().ToList();
            
            return base.Update(a => new Spend()
            {
                RoomNo = newRoom,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            }, a => listSpendId.Contains(a.RoomNo) && a.CustoNo == custoNo && a.MoneyState == "未结算" && a.SpendTime >= DateTime.Now
             && a.SpendTime <= DateTime.Now);


        }
        #endregion

    }
}
