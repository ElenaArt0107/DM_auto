using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oef3.Models
{
    class BedrijfContext: DbContext
    {
        public DbSet<Werknemer> Werknemer { get; set; }
        public DbSet<Werkgever> Werkgever { get; set; }
        public DbSet<Specialiteit> Specialiteit { get; set; }
        public DbSet<Afdeling> Afdeling { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=bedrijfDatabase;Integrated Security=True");
            }
        }
    }
}
