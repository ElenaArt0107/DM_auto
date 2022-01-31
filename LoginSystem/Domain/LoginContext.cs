using System;
using System.Collections.Generic;
using System.Text;
using Domain.models;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class LoginContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbName = "Login";
                var conString = $"Data Source = localhost; Initial Catalog = {dbName}; Integrated Security=True";
                optionsBuilder.UseSqlServer(conString);
            }
        }
    }
}
