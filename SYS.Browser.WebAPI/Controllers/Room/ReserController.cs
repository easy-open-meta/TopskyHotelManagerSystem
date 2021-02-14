using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 预约信息控制器
    /// </summary>
    public class ReserController: ApiController
    {
        /// <summary>
        /// 根据房间号码查询预约信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        [HttpGet]
        public Reser SelectReserInfoByRoomNo([FromUri]string no)
        {
            Reser r = new ReserService().SelectReserInfoByRoomNo(no);
            return r;
        }

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteReserInfo([FromBody]string rid)
        {
            return new ReserService().DeleteReserInfo(rid);
        }

        /// <summary>
        /// 查询所有预约信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Reser> SelectReserAll()
        {
            return new ReserService().SelectReserAll();
        }

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        [HttpPost]
        public bool InserReserInfo([FromBody]Reser r)
        {
            return new ReserService().InserReserInfo(r);
        }
    }
}
