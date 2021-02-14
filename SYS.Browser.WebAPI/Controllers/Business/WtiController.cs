using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 水电信息控制器(后台)
    /// </summary>
    public class WtiController:ApiController
    {
        #region 根据房间编号查询水电费信息
        /// <summary>
        /// 根据房间编号查询水电费信息
        /// </summary>
        /// <param name="roomNo"></param>
        /// <returns></returns>
        [HttpGet]
        public Wti SelectWtiInfoByRoomNo([FromUri]string roomNo)
        {
            return new WtiService().SelectWtiInfoByRoomNo(roomNo);
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
        [HttpGet]
        public Wti SelectWtiInfoByRoomNoAndTime([FromUri]string roomno, string usedate, string enddate)
        {
            return new WtiService().SelectWtiInfoByRoomNoAndTime(roomno, usedate, enddate);
        }
        #endregion

        #region 获取所有水电费信息
        /// <summary>
        /// 获取所有水电费信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Wti> SelectWtiInfoAll()
        {
            return new WtiService().SelectWtiInfoAll();
        }
        #endregion

        #region 添加水电费信息
        /// <summary>
        /// 添加水电费信息
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [HttpPost]
        public bool InsertWtiInfo([FromBody]Wti w)
        {
            return new WtiService().InsertWtiInfo(w);
        }
        #endregion

        #region 修改水电费信息(根据房间编号)
        /// <summary>
        /// 修改水电费信息(根据房间编号)
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdateWtiInfo([FromBody]Wti w)
        {
            return new WtiService().UpdateWtiInfo(w);
        }
        #endregion

        #region 根据房间信息、使用时间修改水电费
        /// <summary>
        /// 根据房间信息、使用时间修改水电费
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdateWtiInfoByRoomNoAndDateTime([FromBody]Wti w)
        {
            return new WtiService().UpdateWtiInfoByRoomNoAndDateTime(w);
        }
        #endregion

        #region 删除水电费信息:根据房间编号
        /// <summary>
        /// 删除水电费信息:根据房间编号
        /// </summary>
        /// <param name="roomno"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteWtiInfo([FromBody]string roomno)
        {
            return new WtiService().DeleteWtiInfo(roomno);
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
        [HttpDelete]
        public bool DeleteWtiInfoByRoomNoAndDateTime([FromBody]string roomno, string usedate, string enddate)
        {
            return new WtiService().DeleteWtiInfoByRoomNoAndDateTime(roomno, usedate, enddate);
        }
        #endregion
    }
}
