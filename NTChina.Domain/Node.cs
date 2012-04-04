using System.Collections.Generic;

namespace NTChina.Domain
{
    /// <summary>
    /// 节点实体
    /// </summary>
    public class Node
    {
        public long Id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 节点别名
        /// </summary>
        public string Slug { get; set; }

        public virtual ICollection<Topic> Topics { get; set; }
    }
}
