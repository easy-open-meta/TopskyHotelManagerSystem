﻿using System.Collections.Generic;
using Core;
using SYS.Application;

namespace TSHotelManagerSystem.BLL
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
