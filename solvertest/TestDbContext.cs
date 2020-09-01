using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OData.UriParser.Aggregation;

namespace solvertest
{
    public class TestDbContext: DbContext
    {
        public TestDbContext() : base()
        {
            
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var connectionString = config.GetConnectionString("db");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<solverweb.model.Cities>()
                .ToTable("Cities", "Application");
        }

        public DbSet<solverweb.model.Cities> Cities { get; set; }
    }
}
