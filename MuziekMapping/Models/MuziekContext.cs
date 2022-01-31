using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuziekMapping.Models
{
    public class MuziekContext : DbContext

    {
        public DbSet<Lied> Lied { get; set; }
        public DbSet<Album> Album { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=muziekDatabase;Integrated Security=True");
            }
        }

    }
}
