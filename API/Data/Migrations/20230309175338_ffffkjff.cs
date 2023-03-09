using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ffffkjff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeffCaratOrGm",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffCaratOrGm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffCountryOfOrigin",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffCountryOfOrigin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffCustomer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassPortNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIDFront = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CIDBack = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MIDFront = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MIDBack = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PassportFront = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PassportBack = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DLicenseFront = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DLicenseBack = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DSignatureFront = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    DSignatureBack = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffCustomer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffCustomerPhone",
                columns: table => new
                {
                    CID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DeffGoldBarCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    BarCodeTypeAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarCodeTypeEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarCodeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarCodeX = table.Column<float>(type: "real", nullable: false),
                    BarCodeY = table.Column<float>(type: "real", nullable: false),
                    IsVisible = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffGoldBarCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffItemCondition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffItemCondition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffKarat",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffKarat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffPayMethod",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    PayMethodAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayMethodEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffPayMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneClarity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneClarity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneColor",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDiamondColor = table.Column<bool>(type: "bit", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneCut",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneCut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoneTypeCode = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffSupplier",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffSupplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffTaxExempt",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffTaxExempt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldDeffItemName",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BarCodeString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldDeffItemName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldStock",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    AnotherCode = table.Column<long>(type: "bigint", nullable: false),
                    AnotherCode2 = table.Column<long>(type: "bigint", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Karat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoldWeight = table.Column<double>(type: "float", nullable: false),
                    MakingCharge = table.Column<double>(type: "float", nullable: true),
                    CostPerPiece = table.Column<double>(type: "float", nullable: true),
                    CostPerGram = table.Column<double>(type: "float", nullable: true),
                    CostPerGramPurchase = table.Column<double>(type: "float", nullable: true),
                    CostForSeller = table.Column<double>(type: "float", nullable: true),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPieces = table.Column<int>(type: "int", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Document = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: true),
                    SupplierInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<int>(type: "int", nullable: true),
                    ItemNo = table.Column<int>(type: "int", nullable: true),
                    UserCode = table.Column<int>(type: "int", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaxExempt = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldStock", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldStone",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoneTypeCode = table.Column<long>(type: "bigint", nullable: false),
                    StoneNameCode = table.Column<long>(type: "bigint", nullable: false),
                    StoneWeight = table.Column<long>(type: "bigint", nullable: false),
                    StoneWeightType = table.Column<int>(type: "int", nullable: false),
                    StoneColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoneClarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoneCut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StoneCountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StonePrice = table.Column<double>(type: "float", nullable: false),
                    StonePhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    StoneDocument = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CodeItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCode = table.Column<int>(type: "int", nullable: false),
                    Enabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldStone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCode = table.Column<long>(type: "bigint", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SavedLogin = table.Column<int>(type: "int", nullable: false),
                    MacNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffCaratOrGm");

            migrationBuilder.DropTable(
                name: "DeffCountryOfOrigin");

            migrationBuilder.DropTable(
                name: "DeffCustomer");

            migrationBuilder.DropTable(
                name: "DeffCustomerPhone");

            migrationBuilder.DropTable(
                name: "DeffGoldBarCode");

            migrationBuilder.DropTable(
                name: "DeffItemCondition");

            migrationBuilder.DropTable(
                name: "DeffKarat");

            migrationBuilder.DropTable(
                name: "DeffPayMethod");

            migrationBuilder.DropTable(
                name: "DeffStoneClarity");

            migrationBuilder.DropTable(
                name: "DeffStoneColor");

            migrationBuilder.DropTable(
                name: "DeffStoneCut");

            migrationBuilder.DropTable(
                name: "DeffStoneName");

            migrationBuilder.DropTable(
                name: "DeffStoneType");

            migrationBuilder.DropTable(
                name: "DeffSupplier");

            migrationBuilder.DropTable(
                name: "DeffTaxExempt");

            migrationBuilder.DropTable(
                name: "GoldDeffItemName");

            migrationBuilder.DropTable(
                name: "GoldStock");

            migrationBuilder.DropTable(
                name: "GoldStone");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
