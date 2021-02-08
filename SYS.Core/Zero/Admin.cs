namespace SYS.Core
{
    public class Admin
    {
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string AdminAccount { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdminPassword { get; set; }
        /// <summary>
        /// 管理员类型
        /// </summary>
        public string AdminType { get; set; }
        /// <summary>
        /// 管理员名称
        /// </summary>
        public string AdminName { get; set; }
        /// <summary>
        /// 是否为超级管理员
        /// </summary>
        public int IsAdmin { get; set; }

    }
}
