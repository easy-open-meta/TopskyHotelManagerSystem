using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 预约信息接口
    /// </summary>
    public interface IReserService
    {

        /// <summary>
        /// 获取所有预约信息
        /// </summary>
        /// <returns></returns>
        List<Reser> SelectReserAll();

        /// <summary>
        /// 根据房间编号获取预约信息
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        Reser SelectReserInfoByRoomNo(string no);

        /// <summary>
        /// 删除预约信息
        /// </summary>
        /// <param name="rid"></param>
        /// <returns></returns>
        bool DeleteReserInfo(string rid);

        /// <summary>
        /// 添加预约信息
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        bool InserReserInfo(Reser r);


    }
}