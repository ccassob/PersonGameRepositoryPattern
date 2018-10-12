using PersonGame.Domain.SharedKernel;
using System.Collections.Generic;

namespace PersonGame.Domain.Interface
{
    public interface IRepository 
    {
        TEntity GetById<TEntity>(int id) where TEntity : BaseEntity;

        List<TEntity> GetAll<TEntity>() where TEntity : BaseEntity;

        TEntity Add<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void Update<TEntity>(TEntity entity) where TEntity : BaseEntity;

        void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity;
    }
}