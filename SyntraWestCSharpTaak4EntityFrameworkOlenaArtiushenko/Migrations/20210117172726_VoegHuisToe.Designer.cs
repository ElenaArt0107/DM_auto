﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Migrations
{
    [DbContext(typeof(GezinContext))]
    [Migration("20210117172726_VoegHuisToe")]
    partial class VoegHuisToe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models.Huis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HuisNummer")
                        .HasColumnType("int");

                    b.Property<int>("StraatId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StraatId");

                    b.ToTable("Huis");
                });

            modelBuilder.Entity("SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models.Straat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Straat");
                });

            modelBuilder.Entity("SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models.Huis", b =>
                {
                    b.HasOne("SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models.Straat", "Straat")
                        .WithMany("Huisen")
                        .HasForeignKey("StraatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Straat");
                });

            modelBuilder.Entity("SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models.Straat", b =>
                {
                    b.Navigation("Huisen");
                });
#pragma warning restore 612, 618
        }
    }
}