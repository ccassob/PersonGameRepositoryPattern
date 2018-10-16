using PersonGame.Domain;
using PersonGame.Domain.Interface;
using System;

namespace PersonGame.Infrastructure.Data
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext context = new AppDbContext();
        private IRepository<Person> departmentRepository;
        private IRepository<Game> courseRepository;

        public IRepository<Person> PersonRepository
        {
            get
            {
                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new EfRepository<Person>(context);
                }
                return departmentRepository;
            }
        }

        public IRepository<Game> GameRepository
        {
            get
            {
                if (this.courseRepository == null)
                {
                    this.courseRepository = new EfRepository<Game>(context);
                }
                return courseRepository;
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