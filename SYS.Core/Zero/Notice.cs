using System;

namespace SYS.Core
{
    /// <summary>
    /// 人名公告
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// 公告编号
        /// </summary>
        public string NoticeNo { get; set; }
        /// <summary>
        /// 公告主题
        /// </summary>
        public string Noticetheme { get; set; }
        /// <summary>
        /// 公告时间
        /// </summary>
        public DateTime NoticeTime { get; set; }
        /// <summary>
        /// 公告正文
        /// </summary>
        public string NoticeContent { get; set; }
        /// <summary>
        /// 发文部门
        /// </summary>
        public string NoticeClub { get; set; }
        /// <summary>
        /// 公布人
        /// </summary>
        public string NoticePerson { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public int delete_mk { get; set; }
        /// <summary>
        /// 资料创建人
        /// </summary>
        public string datains_usr { get; set; }
        /// <summary>
        /// 资料创建时间
        /// </summary>
        public DateTime datains_date { get; set; }
        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }
        /// <summary>
        /// 资料更新时间
        /// </summary>
        public DateTime datachg_date { get; set; }

    }
}
