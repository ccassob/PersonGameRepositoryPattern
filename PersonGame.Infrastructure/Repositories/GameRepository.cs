using Microsoft.EntityFrameworkCore;
using PersonGame.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using PersonGame.Domain;

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

        public IEnumerable<Game> GetByGenre(string name, string gendre)
        {
            return this.Get<Game>(g => g.Genre == name);
        }
    }
}
