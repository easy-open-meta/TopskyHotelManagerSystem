/*
 * MIT License
 *Copyright (c) 2021 咖啡与网络(java-and-net)

 *Permission is hereby granted, free of charge, to any person obtaining a copy
 *of this software and associated documentation files (the "Software"), to deal
 *in the Software without restriction, including without limitation the rights
 *to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *copies of the Software, and to permit persons to whom the Software is
 *furnished to do so, subject to the following conditions:

 *The above copyright notice and this permission notice shall be included in all
 *copies or substantial portions of the Software.

 *THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 *SOFTWARE.
 *
 */
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
