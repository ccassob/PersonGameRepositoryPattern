using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PersonGame.Infrastructure.Data
{
    public class AppGameContextFactory : IDesignTimeDbContextFactory<AppGameDbContext>
    {
        public AppGameDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppGameDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AppDatabase;Integrated Security=True;");

            return new AppGameDbContext(optionsBuilder.Options);
        }
    }
}