﻿// <auto-generated />
using System;
using BibliotheekMapping.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotheekMapping.Migrations
{
    [DbContext(typeof(BibliotheekContext))]
    [Migration("20210113193854_VoegGenreToe")]
    partial class VoegGenreToe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BibliotheekMapping.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Boek", b =>
                {
                    b.Property<int>("BoekID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AutherID")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BoekID");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Boeken");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Klant", b =>
                {
                    b.Property<int>("LidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LidNaam");

                    b.HasKey("LidId");

                    b.ToTable("Leden");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Boek", b =>
                {
                    b.HasOne("BibliotheekMapping.Model.Author", "Author")
                        .WithMany("Boeken")
                        .HasForeignKey("AuthorId");

                    b.HasOne("BibliotheekMapping.Model.Genre", "GenreVanBoek")
                        .WithMany("Boeken")
                        .HasForeignKey("GenreId");

                    b.Navigation("Author");

                    b.Navigation("GenreVanBoek");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Author", b =>
                {
                    b.Navigation("Boeken");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Genre", b =>
                {
                    b.Navigation("Boeken");
                });
#pragma warning restore 612, 618
        }
    }
}
