using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PersonGame.Domain;
using PersonGame.Domain.SharedKernel;

namespace PersonGame.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext()
        //{
            
        //    //var connection = @"Data Source=.;Initial Catalog=AppDatabase;Integrated Security=True;";
        //    //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

        //    //var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //    //optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=AppDatabase;Integrated Security=True;");

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=AppDatabase;Integrated Security=True;");
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
