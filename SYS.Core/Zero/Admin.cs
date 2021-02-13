
namespace SYS.Core
{
    /// <summary>
    /// 管理员实体类
    /// </summary>
    [SqlSugar.SugarTable("admininfo")]
    public class Admin
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Admin()
        {
        }

        private string _AdminAccount;
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string AdminAccount { get { return this._AdminAccount; } set { this._AdminAccount = value; } }

        private string _AdminPassword;
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPassword { get { return this._AdminPassword; } set { this._AdminPassword = value; } }

        private string _AdminType;
        /// <summary>
        /// 管理员类型
        /// </summary>
        public string AdminType { get { return this._AdminType; } set { this._AdminType = value; } }

        private string _AdminName;
        /// <summary>
        /// 管理员名称
        /// </summary>
        public string AdminName { get { return this._AdminName; } set { this._AdminName = value; } }

        private System.Int32 _IsAdmin;
        /// <summary>
        /// 是否为超级管理员
        /// </summary>
        public System.Int32 IsAdmin { get { return this._IsAdmin; } set { this._IsAdmin = value; } }

        private System.Int32 _DeleteMk;
        /// <summary>
        /// 删除标记
        /// </summary>
        public System.Int32 DeleteMk { get { return this._DeleteMk; } set { this._DeleteMk = value; } }

        private string _datains_usr;
        /// <summary>
        /// 资料新增人
        /// </summary>
        public string datains_usr { get { return this._datains_usr; } set { this._datains_usr = value; } }

        private System.DateTime? _datains_time;
        /// <summary>
        /// 资料新增时间
        /// </summary>
        public System.DateTime? datains_time { get { return this._datains_time; } set { this._datains_time = value; } }

        private string _datachg_usr;
        /// <summary>
        /// 资料更新人
        /// </summary>
        public string datachg_usr { get { return this._datachg_usr; } set { this._datachg_usr = value; } }

        private System.DateTime? _datachg_time;
        /// <summary>
        /// 资料更新时间
        /// </summary>
        public System.DateTime? datachg_time { get { return this._datachg_time; } set { this._datachg_time = value; } }
    }
}
