using PersonGame.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PersonGame.Domain.Interface
{
    public interface IRepository 
    {
        TEntity GetById<TEntity>(int id) where TEntity : BaseEntity<int>;      

        IQueryable<TEntity> GetAll<TEntity>(params Expression<Func<TEntity, object>>[] includes) where TEntity : BaseEntity<int>;

        void Add<TEntity>(TEntity entity) where TEntity : BaseEntity<int>;

        void Update<TEntity>(TEntity entity) where TEntity : BaseEntity<int>;

        void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity<int>;

        TEntity Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : BaseEntity<int>;
    }
}