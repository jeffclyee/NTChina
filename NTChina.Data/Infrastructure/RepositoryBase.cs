using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace NTChina.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class 
    {
        private DatabaseContext _dataContext;
        private readonly IDbSet<T> _dbset;

        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            _dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected DatabaseContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }

        public virtual void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual T GetById(long id)
        {
            return _dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Func<T, bool> where)
        {
            return _dbset.Where(where).ToList();
        }

        public T Get(Func<T, Boolean> where)
        {
            return _dbset.Where(where).FirstOrDefault<T>();
        }
    }
}
