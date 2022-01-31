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
    [Migration("20210113183749_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BoekID");

                    b.HasIndex("AuthorId");

                    b.ToTable("Boeken");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Boek", b =>
                {
                    b.HasOne("BibliotheekMapping.Model.Author", "Author")
                        .WithMany("Boeken")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Author", b =>
                {
                    b.Navigation("Boeken");
                });
#pragma warning restore 612, 618
        }
    }
}