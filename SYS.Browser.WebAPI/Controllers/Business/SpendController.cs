using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 消费信息控制器
    /// </summary>
    public class SpendController:ApiController
    {
        /// <summary>
        /// 添加消费信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [HttpPost]
        public int InsertSpendInfo([FromBody]Spend s)
        {
            return SpendService.InsertSpendInfo(s);
        }
        /// <summary>
        /// 根据客户编号查询消费信息
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Spend> SelectSpendByCustoNo([FromUri]string No)
        {
            return SpendService.SelectSpendByCustoNo(No);
        }
        /// <summary>
        /// 查询所有消费信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Spend> SelectSpendInfoAll()
        {
            return SpendService.SelectSpendInfoAll();
        }

        /// <summary>
        /// 根据房间号查询消费的所有信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Spend> SelectSpendInfoRoomNo([FromUri]string RoomNo)
        {
            return SpendService.SelectSpendInfoRoomNo(RoomNo);
        }

        #region 根据房间编号、入住时间到当前时间查询消费总金额
        /// <summary>
        /// 根据房间编号、入住时间到当前时间查询消费总金额
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="custono"></param>
        /// <returns></returns>
        [HttpGet]
        public object SelectMoneyByRoomNoAndTime([FromUri]string roomno,string custono)
        {
            return SpendService.SelectMoneyByRoomNoAndTime(roomno, custono);
        }
        #endregion

        #region 根据房间编号、入住时间和当前时间修改结算状态
        /// <summary>
        /// 根据房间编号、入住时间和当前时间修改结算状态
        /// </summary>
        /// <param name="roomno"></param>
        /// <param name="checktime"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateMoneyState([FromBody]string roomno, string checktime)
        {
            return SpendService.UpdateMoneyState(roomno, checktime);
        }
        #endregion

    }
}
