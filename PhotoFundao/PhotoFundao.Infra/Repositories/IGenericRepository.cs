using System;
using System.Data.Entity;
using System.Linq;

namespace PhotoFundao.Infra.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        DbContext Context { get; set; }

        void Create(TEntity entity);
        void Delete(TEntity entity);
        IQueryable<TEntity> GetAll(Func<TEntity, bool> predicate);
        TEntity GetById(int id);
        void SaveAll();
        void Update(TEntity entity);
    }
}