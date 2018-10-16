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
        private readonly DbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity GetById(int id) 
        {
            return _dbContext.Set<TEntity>().AsNoTracking().SingleOrDefault(c => c.Id == id);
        }

        public IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeExpressions) 
        {
            var dbSet = _dbContext.Set<TEntity>().AsNoTracking();

            IQueryable<TEntity> query = null;
            foreach (var includeExpression in includeExpressions)
            {
                query = dbSet.Include(includeExpression);
            }

            return query ?? dbSet;
        }

        public void Add(TEntity entity) 
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity) 
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate) 
        {
            return _dbContext.Set<TEntity>().Where(predicate).AsNoTracking().FirstOrDefault();
        }
    }
}