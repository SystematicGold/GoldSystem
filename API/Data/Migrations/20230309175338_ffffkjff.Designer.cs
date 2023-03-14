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
<<<<<<<< HEAD:API/Data/Migrations/20230310140831_a.Designer.cs
    [Migration("20230310140831_a")]
    partial class a
========
    [Migration("20230309175338_ffffkjff")]
    partial class ffffkjff
>>>>>>>> 995b3cda21900854b2bbd342b5c7d4f28cdd8f61:API/Data/Migrations/20230309175338_ffffkjff.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Entities.DeffCaratOrGm_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffCaratOrGm");
                });

            modelBuilder.Entity("API.Entities.DeffCountryOfOrigin_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffCountryOfOrigin");
                });

            modelBuilder.Entity("API.Entities.DeffCustomerPhone_", b =>
                {
                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("DeffCustomerPhone");
                });

            modelBuilder.Entity("API.Entities.DeffCustomer_", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("CIDBack")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("CIDFront")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("DLicenseBack")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("DLicenseFront")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("DSignatureBack")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("DSignatureFront")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("MIDBack")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("MIDFront")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassPortNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PassportBack")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PassportFront")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffCustomer");
                });

            modelBuilder.Entity("API.Entities.DeffGoldBarCode_", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BarCodeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarCodeTypeAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarCodeTypeEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("BarCodeX")
                        .HasColumnType("real");

                    b.Property<float>("BarCodeY")
                        .HasColumnType("real");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("IsVisible")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeffGoldBarCode");
                });

            modelBuilder.Entity("API.Entities.DeffItemCondition_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffItemCondition");
                });

            modelBuilder.Entity("API.Entities.DeffKarat_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffKarat");
                });

            modelBuilder.Entity("API.Entities.DeffPayMethod_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("PayMethodAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayMethodEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffPayMethod");
                });

            modelBuilder.Entity("API.Entities.DeffStoneClarity_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffStoneClarity");
                });

            modelBuilder.Entity("API.Entities.DeffStoneColor_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiamondColor")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffStoneColor");
                });

            modelBuilder.Entity("API.Entities.DeffStoneCut_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffStoneCut");
                });

            modelBuilder.Entity("API.Entities.DeffStoneName_", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoneTypeCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DeffStoneName");
                });

            modelBuilder.Entity("API.Entities.DeffStoneType_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffStoneType");
                });

            modelBuilder.Entity("API.Entities.DeffSupplier_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffSupplier");
                });

            modelBuilder.Entity("API.Entities.DeffTaxExempt_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeffTaxExempt");
                });

            modelBuilder.Entity("API.Entities.GoldDeffItemName_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("BarCodeString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("NameAr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameEn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GoldDeffItemName");
                });

            modelBuilder.Entity("API.Entities.GoldStock_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AnotherCode")
                        .HasColumnType("bigint");

                    b.Property<long>("AnotherCode2")
                        .HasColumnType("bigint");

                    b.Property<string>("BarCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Code")
                        .HasColumnType("bigint");

                    b.Property<int?>("Condition")
                        .HasColumnType("int");

                    b.Property<double?>("CostForSeller")
                        .HasColumnType("float");

                    b.Property<double?>("CostPerGram")
                        .HasColumnType("float");

                    b.Property<double?>("CostPerGramPurchase")
                        .HasColumnType("float");

                    b.Property<double?>("CostPerPiece")
                        .HasColumnType("float");

                    b.Property<string>("CountryOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateAdd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfManufacture")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Document")
                        .HasColumnType("varbinary(max)");

<<<<<<<< HEAD:API/Data/Migrations/20230310140831_a.Designer.cs
                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

========
>>>>>>>> 995b3cda21900854b2bbd342b5c7d4f28cdd8f61:API/Data/Migrations/20230309175338_ffffkjff.Designer.cs
                    b.Property<double>("GoldWeight")
                        .HasColumnType("float");

                    b.Property<int?>("ItemNo")
                        .HasColumnType("int");

                    b.Property<string>("Karat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("MakingCharge")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfPieces")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("Supplier")
                        .HasColumnType("int");

                    b.Property<string>("SupplierInvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaxExempt")
                        .HasColumnType("int");

                    b.Property<int?>("UserCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GoldStock");
                });

            modelBuilder.Entity("API.Entities.GoldStone_", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CodeItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("StoneClarity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoneColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoneCountryOfOrigin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoneCut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("StoneDocument")
                        .HasColumnType("varbinary(max)");

                    b.Property<long>("StoneNameCode")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("StonePhoto")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("StonePrice")
                        .HasColumnType("float");

                    b.Property<long>("StoneTypeCode")
                        .HasColumnType("bigint");

                    b.Property<long>("StoneWeight")
                        .HasColumnType("bigint");

                    b.Property<int>("StoneWeightType")
                        .HasColumnType("int");

                    b.Property<int>("UserCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GoldStone");
                });

            modelBuilder.Entity("API.Entities.User_", b =>
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

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
