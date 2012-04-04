﻿using NTChina.Data.Sqlserver.Infrastructure;
using NTChina.Domain;
using NTChina.Domain.Repositories;

namespace NTChina.Data.Sqlserver.Repositories
{
    public class TopicRepository:RepositoryBase<Topic>,ITopicRepository
    {
        public TopicRepository(DatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
