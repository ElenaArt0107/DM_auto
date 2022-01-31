using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oef2.Models
{
    class RekeningContext : DbContext
    {
        public DbSet<Factuur> Factuur { get; set; }
        public DbSet<Factuurlijn> Factuurlijn { get; set; }
        public DbSet<Artikel> Artikel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=rekeningDatabase;Integrated Security=True");
            }
        }

    }
}
