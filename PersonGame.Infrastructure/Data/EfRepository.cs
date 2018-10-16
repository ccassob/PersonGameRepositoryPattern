using Microsoft.EntityFrameworkCore;
using PersonGame.Domain.Interface;
using PersonGame.Domain.SharedKernel;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PersonGame.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly DbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity GetById<TEntity>(int id) where TEntity : BaseEntity<int>
        {
            return _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public IQueryable<TEntity> GetAll<TEntity>(params Expression<Func<TEntity, object>>[] includeExpressions) where TEntity : BaseEntity<int>
        {
            var dbSet = _dbContext.Set<TEntity>().AsNoTracking();

            IQueryable<TEntity> query = null;
            foreach (var includeExpression in includeExpressions)
            {
                query = dbSet.Include(includeExpression);
            }

            return query ?? dbSet;
        }

        public void Add<TEntity>(TEntity entity) where TEntity : BaseEntity<int>
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity<int>
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : BaseEntity<int>
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public TEntity Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : BaseEntity<int>
        {
            return _dbContext.Set<TEntity>().AsNoTracking().Where(predicate).FirstOrDefault();
        }
    }
}