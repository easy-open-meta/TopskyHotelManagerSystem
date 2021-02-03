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
        public Reser SelectReserInfoByRoomNo(string no)
        {
            Reser r = ReserService.SelectReserInfoByRoomNo(no);
            return r;
        }

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        public int DeleteReserInfo(string rid)
        {
            return ReserService.DeleteReserInfo(rid);
        }

        /// <summary>
        /// 查询所有预约信息
        /// </summary>
        /// <returns></returns>
        public List<Reser> SelectReserAll()
        {
            return ReserService.SelectReserAll();
        }

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int InserReserInfo(Reser r)
        {
            return ReserService.InserReserInfo(r);
        }
    }
}
