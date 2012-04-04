using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NTChina.Data.Infrastructure;
using NTChina.Data.Interfaces;
using NTChina.Entity;

namespace NTChina.Data.Repositories
{
    public class NodeRepository:RepositoryBase<Node>,INodeRepository
    {
        public NodeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
