using System;
using System.Data.Entity;
using System.Linq;

namespace PhotoFundao.Infra.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        public DbContext Context { get; set; }

        public GenericRepository(DbContext context)
        {
            Context = context;
        }

        public void Create(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll(Func<TEntity,bool> predicate)
        {
            return Context.Set<TEntity>()
                .Where(predicate)
                .AsQueryable();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void SaveAll()
        {
            Context.SaveChanges();
        }
    }
}
