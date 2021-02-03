using System.Collections.Generic;
using SYS.Core;
using SYS.Application;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 任命公告控制器
    /// </summary>
    public class NoticeController:ApiController
    {
        #region 获取所有公告信息
        /// <summary>
        /// 获取所有公告信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Notice> SelectNoticeAll()
        {
            return NoticeService.SelectNoticeAll();
        }
        #endregion
    }
}
