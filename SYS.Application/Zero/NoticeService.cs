using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SYS.Common;
using SYS.Core;

namespace SYS.Application
{
    /// <summary>
    /// 公告信息接口实现类
    /// </summary>
    public class NoticeService:Repository<Notice>, INoticeService
    {
        #region 获取所有公告信息
        /// <summary>
        /// 获取所有公告信息
        /// </summary>
        /// <returns></returns>
        public List<Notice> SelectNoticeAll()
        {
            List<Notice> ntc = new List<Notice>();
            ntc = base.GetList(a => a.delete_mk != 1);
            return ntc;
        }
        #endregion
    }
}
