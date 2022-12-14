// <auto-generated />
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
    [Migration("20220824071512_people")]
    partial class people
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

            modelBuilder.Entity("ProductCatalogApp.Entities.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonID"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
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

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.Property<int>("ProductsProductID")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersPersonID")
                        .HasColumnType("int");

                    b.HasKey("ProductsProductID", "SuppliersPersonID");

                    b.HasIndex("SuppliersPersonID");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("ProductCatalogApp.Entities.Customer", b =>
                {
                    b.HasBaseType("ProductCatalogApp.Entities.Person");

                    b.Property<string>("CustomerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("ProductCatalogApp.Entities.Supplier", b =>
                {
                    b.HasBaseType("ProductCatalogApp.Entities.Person");

                    b.Property<string>("GST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Supplier");
                });

            modelBuilder.Entity("ProductCatalogApp.Entities.Product", b =>
                {
                    b.HasOne("ProductCatalogApp.Entities.Catagory", "Catagory")
                        .WithMany("Products")
                        .HasForeignKey("CatagoryID");

                    b.Navigation("Catagory");
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.HasOne("ProductCatalogApp.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductCatalogApp.Entities.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SuppliersPersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductCatalogApp.Entities.Catagory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
