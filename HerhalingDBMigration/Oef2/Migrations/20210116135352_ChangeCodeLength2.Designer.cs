// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oef2.Models;

namespace Oef2.Migrations
{
    [DbContext(typeof(RekeningContext))]
    [Migration("20210116135352_ChangeCodeLength2")]
    partial class ChangeCodeLength2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Oef2.Models.Artikel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Artikel");
                });

            modelBuilder.Entity("Oef2.Models.Factuur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FactuurNummer")
                        .HasColumnType("int");

                    b.Property<string>("KlantNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Factuur");
                });

            modelBuilder.Entity("Oef2.Models.Factuurlijn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ArtikelId")
                        .HasColumnType("int");

                    b.Property<int>("FactuurId")
                        .HasColumnType("int");

                    b.Property<int?>("Hoeveelheid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtikelId");

                    b.HasIndex("FactuurId");

                    b.ToTable("Factuurlijn");
                });

            modelBuilder.Entity("Oef2.Models.Factuurlijn", b =>
                {
                    b.HasOne("Oef2.Models.Artikel", "Artikel")
                        .WithMany("Factuurlijnen")
                        .HasForeignKey("ArtikelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Oef2.Models.Factuur", "Factuur")
                        .WithMany("Factuurlijnen")
                        .HasForeignKey("FactuurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artikel");

                    b.Navigation("Factuur");
                });

            modelBuilder.Entity("Oef2.Models.Artikel", b =>
                {
                    b.Navigation("Factuurlijnen");
                });

            modelBuilder.Entity("Oef2.Models.Factuur", b =>
                {
                    b.Navigation("Factuurlijnen");
                });
#pragma warning restore 612, 618
        }
    }
}
