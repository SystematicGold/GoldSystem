﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221209110520_hvjjhf")]
    partial class hvjjhf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Entities.AnotherAnotherCategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AnotherCode")
                        .HasColumnType("bigint");

                    b.Property<string>("BarCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<float>("CostPerGram")
                        .HasColumnType("real");

                    b.Property<string>("Kart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Making")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberPieces")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("AnotherAnotherCategory");
                });

            modelBuilder.Entity("API.Entities.AnotherPieces", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BarCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CategoriesCode")
                        .HasColumnType("bigint");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<float>("CostPerGram")
                        .HasColumnType("real");

                    b.Property<string>("Kart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Making")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberPieces")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("AnotherPiece");
                });

            modelBuilder.Entity("API.Entities.Categories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BarCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<float>("CostPerGram")
                        .HasColumnType("real");

                    b.Property<string>("Kart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MadeIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Making")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberPieces")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("API.Entities.KartItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KartItems");
                });

            modelBuilder.Entity("API.Entities.StoneCategoris", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StoneCategory");
                });

            modelBuilder.Entity("API.Entities.StoneItemCategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoriesCode")
                        .HasColumnType("bigint");

                    b.Property<string>("Colour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("StoneCode")
                        .HasColumnType("bigint");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("StoneItemCategory");
                });

            modelBuilder.Entity("API.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MacNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("SavedLogin")
                        .HasColumnType("int");

                    b.Property<long?>("UserCode")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
