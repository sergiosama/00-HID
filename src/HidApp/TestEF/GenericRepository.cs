using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class IGenericRepository<TEntity, TContext> : IGenericRepository<TEntity>, IDisposable
        where TEntity : class
        where TContext : DbContext
    {
        protected TContext Context;

        public IGenericRepository(DbContext dbContext)
        {
            Context = dbContext as TContext;
        }

        public virtual TEntity Create()
        {
            return Context.Set<TEntity>().Create();
        }

        public virtual TEntity Create(TEntity entity)
        {
            return Context.Set<TEntity>().Add(entity);
        }

        public virtual TEntity Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual void Delete(int id)
        {
            var item = Context.Set<TEntity>().Find(id);
            Context.Set<TEntity>().Remove(item);
        }

        public virtual void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> where)
        {
            var objects = Context.Set<TEntity>().Where(where).AsEnumerable();
            foreach (var item in objects)
            {
                Context.Set<TEntity>().Remove(item);
            }
        }

        public virtual TEntity FindById(long id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public virtual TEntity FindOne(Expression<Func<TEntity, bool>> where = null)
        {
            return FindAll(where).FirstOrDefault();
        }

        public IQueryable<T> Set<T>() where T : class
        {
            return Context.Set<T>();
        }

        public virtual IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> where = null)
        {
            return null != where ? Context.Set<TEntity>().Where(where) : Context.Set<TEntity>();
        }

        public virtual bool SaveChanges()
        {
            return 0 < Context.SaveChanges();
        }

        /// <summary>
        /// Releases all resources used by the Entities
        /// </summary>
        public void Dispose()
        {
            if (null != Context)
            {
                Context.Dispose();
            }
        }
    }
   
}
