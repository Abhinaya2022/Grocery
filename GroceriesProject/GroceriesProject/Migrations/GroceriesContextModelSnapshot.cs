﻿// <auto-generated />
using System;
using GroceriesProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroceriesProject.Migrations
{
    [DbContext(typeof(GroceriesContext))]
    partial class GroceriesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GroceriesProject.Models.GroceriesList", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Name");

                    b.ToTable("Groceries");
                });

            modelBuilder.Entity("GroceriesProject.Models.GroveriesPurchase", b =>
                {
                    b.Property<string>("GroceryName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GroceryQuantity")
                        .HasColumnType("int");

                    b.HasKey("GroceryName");

                    b.ToTable("GroveriesPurchases");
                });
#pragma warning restore 612, 618
        }
    }
}