using Domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class RekeningContext : DbContext
    {
        public RekeningContext()
        {

        }

        public RekeningContext(DbContextOptions<RekeningContext> options) : base(options)
        {

        }

        public DbSet<Rekening> Rekeningen { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = "Data Source=localhost;Initial Catalog=Rekening_Database;Integrated Security=True";
                optionsBuilder.UseSqlServer(connString);
            }
        }
    }
}
