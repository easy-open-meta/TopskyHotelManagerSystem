using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 房间类型控制器
    /// </summary>
    public class RoomTypeController : ApiController
    {
        #region 获取所有房间类型
        /// <summary>
        /// 获取所有房间类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<RoomType> SelectRoomTypesAll()
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
        [HttpPost]
        public RoomType SelectRoomTypeByRoomNo([FromBody]string no)
        {
            return RoomTypeService.SelectRoomTypeByRoomNo(no);
        }
        #endregion
    }
}
