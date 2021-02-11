using System;

namespace SYS.Core
{
    /// <summary>
    /// 员工信息
    /// </summary>
    [SqlSugar.SugarTable("worker")]
    public class Worker
    {
        /// <summary>
        /// 员工账号/工号
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerId")]
        public string WorkerId { get; set; }
        /// <summary>
        /// 员工姓名
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerName")]
        public string WorkerName { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerBirthday")]
        public DateTime WorkerBirthday { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerSex")]
        public int WorkerSex { get; set; }
        /// <summary>
        /// 员工性别(名称描述)
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string WorkerSexName { get; set; }
        /// <summary>
        /// 民族类型
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerNation")]
        public string WorkerNation { get; set; }
        /// <summary>
        /// 民族名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string NationName { get; set; }
        /// <summary>
        /// 员工电话
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerTel")]
        public string WorkerTel { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerClub")]
        public string WorkerClub { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string ClubName { get; set; }
        /// <summary>
        /// 居住地址
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerAddress")]
        public string WorkerAddress { get; set; }
        /// <summary>
        /// 员工职位
        /// </summary>
        [SqlSugar.SugarColumn(ColumnName = "WorkerPosition")]
        public string WorkerPosition { get; set; }
        /// <summary>
        /// 职位名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string PositionName { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string CardId { get; set; }
        /// <summary>
        /// 员工密码
        /// </summary>
        public string WorkerPwd { get; set; }
        /// <summary>
        /// 员工入职时间
        /// </summary>
        public DateTime WorkerTime { get; set; }
        /// <summary>
        /// 员工面貌
        /// </summary>
        public string WorkerFace { get; set; }
        /// <summary>
        /// 群众面貌描述
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string FaceName { get; set; }
        /// <summary>
        /// 教育程度
        /// </summary>
        public string WorkerEducation { get; set; }
        /// <summary>
        /// 教育程度名称
        /// </summary>
        [SqlSugar.SugarColumn(IsIgnore = true)]
        public string EducationName { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public int? delete_mk { get; set; }
        /// <summary>
        /// 资料创建人
        /// </summary>
        public string datains_usr { get; set; }
        /// <summary>
        /// 资料创建时间
        /// </summary>
        public DateTime? datains_date { get; set; }
        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get; set; }
        /// <summary>
        /// 资料更新时间
        /// </summary>
        public DateTime? datachg_date { get; set; }
    }
}
