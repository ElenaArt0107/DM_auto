// <auto-generated />
using System;
using BibliotheekMapping.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotheekMapping.Migrations
{
    [DbContext(typeof(BibliotheekContext))]
    partial class BibliotheekContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("BibliotheekMapping.Model.BoekenPerOntlening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BoekId")
                        .HasColumnType("int");

                    b.Property<int>("OntleningId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoekId");

                    b.HasIndex("OntleningId");

                    b.ToTable("BoekenPerOntlening");
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

            modelBuilder.Entity("BibliotheekMapping.Model.Ontlening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KalntId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Van")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Voor")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KalntId");

                    b.ToTable("Ontleningen");
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

            modelBuilder.Entity("BibliotheekMapping.Model.BoekenPerOntlening", b =>
                {
                    b.HasOne("BibliotheekMapping.Model.Boek", "Boek")
                        .WithMany("BoekenPerOntlening")
                        .HasForeignKey("BoekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BibliotheekMapping.Model.Ontlening", "Ontlening")
                        .WithMany("BoekenPerOntlening")
                        .HasForeignKey("OntleningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boek");

                    b.Navigation("Ontlening");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Ontlening", b =>
                {
                    b.HasOne("BibliotheekMapping.Model.Klant", "Klant")
                        .WithMany("Ontleningen")
                        .HasForeignKey("KalntId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klant");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Author", b =>
                {
                    b.Navigation("Boeken");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Boek", b =>
                {
                    b.Navigation("BoekenPerOntlening");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Genre", b =>
                {
                    b.Navigation("Boeken");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Klant", b =>
                {
                    b.Navigation("Ontleningen");
                });

            modelBuilder.Entity("BibliotheekMapping.Model.Ontlening", b =>
                {
                    b.Navigation("BoekenPerOntlening");
                });
#pragma warning restore 612, 618
        }
    }
}
