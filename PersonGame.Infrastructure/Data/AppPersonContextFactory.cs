using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PersonGame.Infrastructure.Data
{
    public class AppPersonContextFactory : IDesignTimeDbContextFactory<AppPersonDbContext>
    {
        public AppPersonDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppPersonDbContext>();
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AppDatabase;Integrated Security=True;");

            return new AppPersonDbContext(optionsBuilder.Options);
        }
    }
}