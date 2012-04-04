using NTChina.Data.Infrastructure;
using NTChina.Data.Interfaces;
using NTChina.Entity;

namespace NTChina.Data.Repositories
{
    public class TopicRepository:RepositoryBase<Topic>,ITopicRepository
    {
        public TopicRepository(DatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
