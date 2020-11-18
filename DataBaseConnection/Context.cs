using System;
using Microsoft.EntityFrameworkCore;

namespace DataBaseConnection
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.LogTo(s => System.Diagnostics.Debug.WriteLine(s))
                .UseLazyLoadingProxies()
                .UseSqlServer(
                @"server=.\SQLExpress;" +
                @"database=SaleDataBase;" +
                @"trusted_connection=true;" +
                @"MultipleActiveResultSets=True"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
