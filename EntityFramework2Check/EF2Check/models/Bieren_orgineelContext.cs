using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EF2Check.models
{
    public partial class Bieren_orgineelContext : DbContext
    {
        public Bieren_orgineelContext()
        {
        }

        public Bieren_orgineelContext(DbContextOptions<Bieren_orgineelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bier> Bieren { get; set; }
        public virtual DbSet<Brouwer> Brouwers { get; set; }
        public virtual DbSet<Soort> Soorten { get; set; }
        public virtual DbSet<Persoon> Personen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=bieren_orgineel;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Bier>(entity =>
            {
                entity.HasKey(e => e.BierNr)
                    .HasName("PK__bieren__F41525D0DC09EB44");

                entity.ToTable("bieren");

                entity.Property(e => e.BierNr).ValueGeneratedNever();

                entity.Property(e => e.BierNaam)
                .HasColumnName("Naam")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Rating);
            });

            modelBuilder.Entity<Brouwer>(entity =>
            {
                entity.HasKey(e => e.BrouwerNr)
                    .HasName("PK__brouwers__6FCD96D511A19640");

                entity.ToTable("brouwers");

                entity.Property(e => e.BrouwerNr).ValueGeneratedNever();

                entity.Property(e => e.Adres)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrouwerNaam)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gemeente)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Soort>(entity =>
            {
                entity.HasKey(e => e.SoortNr)
                    .HasName("PK__soorten__6327B77A02EFC7B8");

                entity.ToTable("soorten");

                entity.Property(e => e.SoortNr).ValueGeneratedNever();

                entity.Property(e => e.SoortNaam)
                    .HasColumnName("Soort")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Persoon>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__personnen");

                entity.ToTable("Personnen");

                entity.Property(e => e.Naam)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(persoon => persoon.FavouriteBier1)
                    .WithMany(bier => bier.PplWithBier1)
                    .HasForeignKey(Persoon => Persoon.FavouriteBierId1)
                    .HasConstraintName("FK_FavouriteBier1");

                entity.HasOne(persoon => persoon.FavouriteBier2)
                   .WithMany(bier => bier.PplWithBier2)
                   .HasForeignKey(Persoon => Persoon.FavouriteBierId2)
                   .HasConstraintName("FK_FavouriteBier2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
