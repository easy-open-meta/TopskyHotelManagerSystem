using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 预约信息接口实现类
    /// </summary>
    public class ReserService:Repository<Reser>,IReserService
    {
        /// <summary>
        /// 获取所有预约信息
        /// </summary>
        /// <returns></returns>
        public List<Reser> SelectReserAll()
        {
            List<Reser> rss = new List<Reser>();
            rss = base.GetList(a => a.delete_mk == 0);
            return rss;
        }

        /// <summary>
        /// 根据房间编号获取预约信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        public Reser SelectReserInfoByRoomNo(string no)
        {
            Reser res = null;
            res = base.GetSingle(a => a.ReserRoom == no && a.delete_mk != 1);
            return res;
        }

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public bool DeleteReserInfo(string rid)
        {
            return base.Update(a => new Reser()
            {
                delete_mk = 1,
                datachg_usr = LoginInfo.WorkerNo,
                datachg_date = DateTime.Now
            },a => a.ReserId == rid);

        }

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public bool InserReserInfo(Reser r)
        {
            return base.Insert(r);
        }


    }
}
