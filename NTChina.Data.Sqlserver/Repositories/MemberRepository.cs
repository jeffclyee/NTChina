using NTChina.Data.Sqlserver.Infrastructure;
using NTChina.Domain;
using NTChina.Domain.Repositories;

namespace NTChina.Data.Sqlserver.Repositories
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
