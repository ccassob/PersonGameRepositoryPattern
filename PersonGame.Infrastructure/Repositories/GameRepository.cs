using Microsoft.EntityFrameworkCore;
using PersonGame.Infrastructure.Data;

namespace PersonGame.Infrastructure.Repositories
{
    public class GameRepository : EfRepository
    {
        private readonly DbContext _dbContext;

        public GameRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}