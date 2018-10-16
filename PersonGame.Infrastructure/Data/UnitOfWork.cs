using PersonGame.Domain;
using PersonGame.Domain.Interface;
using System;

namespace PersonGame.Infrastructure.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AppPersonDbContext personDbContext;
        private AppGameDbContext gameDbContext;
        private IRepository<Person> personRepository;
        private IRepository<Game> gameRepository;

        public UnitOfWork(AppPersonDbContext dbContext1, AppGameDbContext dbContext2)
        {
            personDbContext = dbContext1;
            gameDbContext = dbContext2;
        }

        public IRepository<Person> PersonRepository
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository = new EfRepository<Person>(personDbContext);
                }
                return personRepository;
            }
        }

        public IRepository<Game> GameRepository
        {
            get
            {
                if (gameRepository == null)
                {
                    gameRepository = new EfRepository<Game>(gameDbContext);
                }
                return gameRepository;
            }
        }

        public void Commit()
        {
            gameDbContext.SaveChanges();
            personDbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    personDbContext.Dispose();
                    gameDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}