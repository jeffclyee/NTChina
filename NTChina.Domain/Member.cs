namespace NTChina.Domain
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class Member
    {
        public long Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
