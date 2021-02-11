using SYS.Core;
using System.Collections.Generic;

namespace SYS.Application
{
    /// <summary>
    /// 公告接口
    /// </summary>
    public interface INoticeService
    {
        #region 获取所有公告信息
        /// <summary>
        /// 获取所有公告信息
        /// </summary>
        /// <returns></returns>
        List<Notice> SelectNoticeAll();
        #endregion
    }
}