using Microsoft.EntityFrameworkCore;
using PersonGame.Domain;

namespace PersonGame.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}