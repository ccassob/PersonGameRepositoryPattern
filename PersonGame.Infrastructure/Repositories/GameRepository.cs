using Microsoft.EntityFrameworkCore;
using PersonGame.Domain;
using PersonGame.Infrastructure.Data;

namespace PersonGame.Infrastructure.Repositories
{
    public class GameRepository : EfRepository<Game>
    {
        private readonly DbContext _dbContext;

        public GameRepository(AppDbContext dbContext)
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}