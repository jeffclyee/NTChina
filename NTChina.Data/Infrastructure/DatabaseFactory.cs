namespace NTChina.Data.Infrastructure
{
    public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private DatabaseContext _dataContext;

        public DatabaseContext Get()
        {
            return _dataContext ?? (_dataContext = new DatabaseContext());
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}
