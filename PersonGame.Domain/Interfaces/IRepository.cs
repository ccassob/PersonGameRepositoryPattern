using PersonGame.Domain.SharedKernel;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PersonGame.Domain.Interface
{
    public interface IRepository<TEntity> where TEntity : BaseEntity<int>
    {
        TEntity GetById(int id);

        IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);
    }
}