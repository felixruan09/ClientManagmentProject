﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210131024606_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnName("City")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Neighborhood")
                        .HasColumnName("Neighborhood")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Street")
                        .HasColumnName("Street")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("StreetNumber")
                        .HasColumnName("StreetNumber")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("ZipCode")
                        .HasColumnName("ZipCode")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Domain.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<string>("Birthday")
                        .HasColumnName("Birthday")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Document")
                        .HasColumnName("Document")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("FatherName")
                        .HasColumnName("FatherName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("FullName")
                        .HasColumnName("FullName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("MotherName")
                        .HasColumnName("MotherName")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Domain.Entities.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnName("EmailAddress")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Domain.Entities.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("int");

                    b.Property<string>("AreaCode")
                        .HasColumnName("AreaCode")
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .HasColumnName("CountryCode")
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Number")
                        .HasColumnName("Number")
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("Domain.Entities.Address", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Email", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany("Emails")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Phone", b =>
                {
                    b.HasOne("Domain.Entities.Client", "Client")
                        .WithMany("Phones")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}