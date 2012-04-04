using System.Collections.Generic;

namespace NTChina.Domain
{
    /// <summary>
    /// 主题实体
    /// </summary>
    public class Topic
    {
        public long Id { get; set; }

        /// <summary>
        /// 主题标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 主题内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 发表时间
        /// </summary>
        public string PublicTime { get; set; }

        /// <summary>
        /// 回复数量
        /// </summary>
        public string ReplyNum { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// 所属节点
        /// </summary>
        public virtual ICollection<Node> Nodes { get; set; }
    }
}
