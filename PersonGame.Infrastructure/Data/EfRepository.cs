using Microsoft.EntityFrameworkCore;
using PersonGame.Domain.Interface;
using PersonGame.Domain.SharedKernel;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PersonGame.Infrastructure.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _entity;

        public EfRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _entity = _dbContext.Set<TEntity>();            
        }

        public TEntity GetById(int id) 
        {
            return _entity.AsNoTracking().SingleOrDefault(c => c.Id == id);
        }

        public IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeExpressions) 
        {
            var dbSet = _entity.AsNoTracking();

            IQueryable<TEntity> query = null;
            foreach (var includeExpression in includeExpressions)
            {
                query = dbSet.Include(includeExpression);
            }

            return query ?? dbSet;
        }

        public void Add(TEntity entity) 
        {
            _entity.Add(entity);
        }

        public void Delete(TEntity entity) 
        {
            _entity.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate) 
        {
            return _entity.Where(predicate)
                .AsNoTracking()
                .FirstOrDefault();
        }
    }
}