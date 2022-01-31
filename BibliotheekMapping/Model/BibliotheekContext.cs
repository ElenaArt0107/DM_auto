using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheekMapping.Model
{
    public class BibliotheekContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Boek> Boeken { get; set; }
        public virtual DbSet<Klant> Klanten { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Ontlening> Ontleningen { get; set; }
        public virtual DbSet<BoekenPerOntlening> BoekenPerOntlening { get; set; }


        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=bibliotheekDatabase;Integrated Security=True");
            }
        }
    }
}
