namespace NTChina.Data.Sqlserver.Infrastructure
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
