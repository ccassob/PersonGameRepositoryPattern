using PersonGame.Domain;
using PersonGame.Domain.Interface;
using System;

namespace PersonGame.Infrastructure.Data
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private AppDbContext context;
        private IRepository<Person> personRepository;
        private IRepository<Game> gameRepository;

        public UnitOfWork(AppDbContext dbContext)
        {
            context = dbContext;
        }

        public IRepository<Person> PersonRepository
        {
            get
            {
                if (personRepository == null)
                {
                    personRepository = new EfRepository<Person>(context);
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
                    gameRepository = new EfRepository<Game>(context);
                }
                return gameRepository;
            }
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
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