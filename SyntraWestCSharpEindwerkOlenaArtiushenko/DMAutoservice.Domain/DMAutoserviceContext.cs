using DMAutoservice.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain
{
    public class DMAutoserviceContext : DbContext
    {
        public DMAutoserviceContext()
        {

        }
        public DMAutoserviceContext(DbContextOptions<DMAutoserviceContext> options) : base(options)
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<UserCar> UsersCars { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; } //update the migration => wrong type Login to Users
        public DbSet<RolePerPerson> RolesPerPerson { get; set; }
        public DbSet<Generation> Generations { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<AccountRights> AccountRights { get; set; }
        public DbSet<Right> Rights { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = "Data Source=localhost;Initial Catalog=DMAutoservice;Integrated Security=True";
                optionsBuilder.UseSqlServer(connString);
            }
        }

        //configure FK for 1-1 relations
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Person>()
        //        .HasOne(a => a.Login)
        //        .WithOne(b => b.Person)
        //        .HasForeignKey<Account>(b => b.Id);
        //}

    }


}
