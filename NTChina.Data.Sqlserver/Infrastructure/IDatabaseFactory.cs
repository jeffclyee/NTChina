using System;

namespace NTChina.Data.Sqlserver.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DatabaseContext Get();
    }
}
