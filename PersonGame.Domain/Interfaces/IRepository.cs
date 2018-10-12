using PersonGame.Domain.SharedKernel;
using System.Collections.Generic;
using System.Linq;

namespace PersonGame.Domain.Interface
{
    public interface IRepository 
    {
        TEntity GetById<TEntity>(int id) where TEntity : BaseEntity;

        IQueryable<TEntity> GetAll<TEntity>() where TEntity : BaseEntity;

        TEntity Add<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void Update<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity;
    }
}