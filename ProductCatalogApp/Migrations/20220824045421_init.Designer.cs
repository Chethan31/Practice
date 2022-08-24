﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductCatalogApp.Data;

#nullable disable

namespace ProductCatalogApp.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220824045421_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductCatalogApp.Entities.Catagory", b =>
                {
                    b.Property<int>("CatagoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatagoryID"), 1L, 1);

                    b.Property<string>("CatagoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatagoryID");

                    b.ToTable("Catagories");
                });

            modelBuilder.Entity("ProductCatalogApp.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"), 1L, 1);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CatagoryID")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductID");

                    b.HasIndex("CatagoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductCatalogApp.Entities.Product", b =>
                {
                    b.HasOne("ProductCatalogApp.Entities.Catagory", "Catagory")
                        .WithMany()
                        .HasForeignKey("CatagoryID");

                    b.Navigation("Catagory");
                });
#pragma warning restore 612, 618
        }
    }
}