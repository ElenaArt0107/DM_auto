using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models
{
    public class GezinContext : DbContext
    {
        public virtual DbSet<Straat> Straat { get; set; }
        public virtual DbSet<Huis> Huis { get; set; }
        public virtual DbSet<Persoon> Persoon { get; set; }
        public virtual DbSet<Hobby> Hobby { get; set; }
        public virtual DbSet<HobbyPerPersoon> HobbyPerPersoon { get; set; }

        protected override void OnConfiguring  (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Hobbies;Integrated Security=True");
            }
        }
    }
}
