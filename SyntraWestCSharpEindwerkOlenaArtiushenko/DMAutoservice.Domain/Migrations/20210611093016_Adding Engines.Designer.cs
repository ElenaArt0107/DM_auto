﻿// <auto-generated />
using DMAutoservice.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DMAutoservice.Domain.Migrations
{
    [DbContext(typeof(DMAutoserviceContext))]
    [Migration("20210611093016_Adding Engines")]
    partial class AddingEngines
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DMAutoservice.Domain.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EngineType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fuel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenerationId")
                        .HasColumnType("int");

                    b.Property<int>("PowerAfterTuning")
                        .HasColumnType("int");

                    b.Property<int>("PowerStandard")
                        .HasColumnType("int");

                    b.Property<int>("TorqueAfterTuning")
                        .HasColumnType("int");

                    b.Property<int>("TorqueStandard")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenerationId");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Generation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenerationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Generations");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("LoginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoginId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Surame")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.RolePerPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("UserId");

                    b.ToTable("RolesPerPerson");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.UserCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("PersonId");

                    b.ToTable("UsersCars");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Engine", b =>
                {
                    b.HasOne("DMAutoservice.Domain.Models.Generation", "GenerationType")
                        .WithMany()
                        .HasForeignKey("GenerationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GenerationType");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Generation", b =>
                {
                    b.HasOne("DMAutoservice.Domain.Models.Model", "ModelType")
                        .WithMany("Generations")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModelType");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Login", b =>
                {
                    b.HasOne("DMAutoservice.Domain.Models.Person", "Person")
                        .WithOne("Log")
                        .HasForeignKey("DMAutoservice.Domain.Models.Login", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Model", b =>
                {
                    b.HasOne("DMAutoservice.Domain.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.RolePerPerson", b =>
                {
                    b.HasOne("DMAutoservice.Domain.Models.Person", "Person")
                        .WithMany("RolesPerPerson")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMAutoservice.Domain.Models.User", "User")
                        .WithMany("PeoplePerRole")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.UserCar", b =>
                {
                    b.HasOne("DMAutoservice.Domain.Models.Brand", "Brand")
                        .WithMany("UserPerCar")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMAutoservice.Domain.Models.Person", "Person")
                        .WithMany("CarsPerPerson")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Brand", b =>
                {
                    b.Navigation("Models");

                    b.Navigation("UserPerCar");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Model", b =>
                {
                    b.Navigation("Generations");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.Person", b =>
                {
                    b.Navigation("CarsPerPerson");

                    b.Navigation("Log");

                    b.Navigation("RolesPerPerson");
                });

            modelBuilder.Entity("DMAutoservice.Domain.Models.User", b =>
                {
                    b.Navigation("PeoplePerRole");
                });
#pragma warning restore 612, 618
        }
    }
}
