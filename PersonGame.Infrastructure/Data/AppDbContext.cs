using Microsoft.EntityFrameworkCore;
using PersonGame.Domain;

namespace PersonGame.Infrastructure.Data
{
    public class AppPersonDbContext : DbContext
    {
        public AppPersonDbContext(DbContextOptions<AppPersonDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("person");
        }

        public DbSet<Person> Persons { get; set; }
    }

    public class AppGameDbContext : DbContext
    {
        public AppGameDbContext(DbContextOptions<AppGameDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("game");
        }

        public DbSet<Game> Games { get; set; }
    }
}