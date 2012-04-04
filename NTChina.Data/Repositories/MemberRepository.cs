using NTChina.Data.Infrastructure;
using NTChina.Data.Interfaces;
using NTChina.Entity;

namespace NTChina.Data.Repositories
{
    public class MemberRepository : RepositoryBase<Member>, IMemberRepository
    {
        public MemberRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
}
