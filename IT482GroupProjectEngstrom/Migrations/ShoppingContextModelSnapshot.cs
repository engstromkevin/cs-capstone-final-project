﻿// <auto-generated />
using System;
using IT482GroupProjectEngstrom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IT482GroupProjectEngstrom.Migrations
{
    [DbContext(typeof(ShoppingContext))]
    partial class ShoppingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("IT482GroupProjectEngstrom.Models.Category", b =>
                {
                    b.Property<string>("CatCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CatDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatCode");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("IT482GroupProjectEngstrom.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine01")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine02")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine03")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("IT482GroupProjectEngstrom.Models.Invoice", b =>
                {
                    b.Property<string>("InvoiceNum")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceNum");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("IT482GroupProjectEngstrom.Models.LineItem", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InvoiceNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("IT482GroupProjectEngstrom.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductDescr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("IT482GroupProjectEngstrom.Models.Product", b =>
                {
                    b.HasOne("IT482GroupProjectEngstrom.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
