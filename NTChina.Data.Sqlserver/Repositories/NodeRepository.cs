using NTChina.Data.Sqlserver.Infrastructure;
using NTChina.Domain;
using NTChina.Domain.Repositories;

namespace NTChina.Data.Sqlserver.Repositories
{
    public class NodeRepository:RepositoryBase<Node>,INodeRepository
    {
        public NodeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
