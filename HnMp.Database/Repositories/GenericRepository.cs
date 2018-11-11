using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace HnMp.Database.Repositories
{
    public abstract class GenericRepository<db, T> :
        IGenericRepository<T> where T : class where db : DbContext, new()
    {
        private db _entities = new db();
        public db Context
        {
            get { return _entities; }
            set { _entities = value; }
        }


        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public virtual void SaveAsync()
        {
            _entities.SaveChangesAsync();
        }
    }
}
