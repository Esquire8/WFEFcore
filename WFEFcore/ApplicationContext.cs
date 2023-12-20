using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WFEFcore
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DataBase.connectionString);
        }

        public DbSet<User> users { get; set; }
    }
}