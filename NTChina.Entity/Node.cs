using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NTChina.Entity
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

    }
}
