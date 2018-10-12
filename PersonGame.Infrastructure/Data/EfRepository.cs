﻿using Microsoft.EntityFrameworkCore;
using PersonGame.Domain.Interface;
using PersonGame.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonGame.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly DbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity GetById<TEntity>(int id) where TEntity : BaseEntity
        {
            return _dbContext.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }

        public List<TEntity> GetAll<TEntity>() where TEntity : BaseEntity
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity Add<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}