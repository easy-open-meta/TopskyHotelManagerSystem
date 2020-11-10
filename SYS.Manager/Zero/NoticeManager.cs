using System.Collections.Generic;
using SYS.Core;
using SYS.Application;

namespace SYS.Manager
{
    public class NoticeManager
    {
        #region 获取所有公告信息
        /// <summary>
        /// 获取所有公告信息
        /// </summary>
        /// <returns></returns>
        public static List<Notice> SelectNoticeAll()
        {
            return NoticeService.SelectNoticeAll();
        }
        #endregion
    }
}
