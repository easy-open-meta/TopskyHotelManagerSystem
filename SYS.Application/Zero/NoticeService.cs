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
            ntc.ForEach(source =>
            {
                switch (source.NoticeType)
                {
                    case "PersonnelChanges":
                        source.NoticeTypeName = "人事变动";
                        break;
                    case "GeneralNotice":
                        source.NoticeTypeName = "普通公告";
                        break;
                }
            });
            return ntc;
        }
        #endregion

        /// <summary>
        /// 根据公告编号查找公告信息
        /// </summary>
        /// <param name="NoticeNo"></param>
        /// <returns></returns>
        public Notice SelectNoticeByNoticeNo(string NoticeNo)
        {
            Notice notice = new Notice();
            notice = base.GetSingle(a => a.NoticeNo == NoticeNo);
            switch (notice.NoticeType)
            {
                case "PersonnelChanges":
                    notice.NoticeTypeName = "人事变动";
                    break;
                case "GeneralNotice":
                    notice.NoticeTypeName = "普通公告";
                    break;
            }
            return notice;
        }

        #region 上传公告信息
        /// <summary>
        /// 上传公告信息
        /// </summary>
        /// <param name="notice"></param>
        /// <returns></returns>
        public bool InsertNotice(Notice notice)
        {
            return base.Insert(notice);
        }

        #endregion

    }
}
