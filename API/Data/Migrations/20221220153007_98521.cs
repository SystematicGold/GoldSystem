using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _98521 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffKaratItem");

            migrationBuilder.DropTable(
                name: "DeffStoneCategory");

            migrationBuilder.DropTable(
                name: "DeffStoneItemCategory");

            migrationBuilder.DropTable(
                name: "GoldCategory");

            migrationBuilder.DropTable(
                name: "GoldItemName");

            migrationBuilder.CreateTable(
                name: "DeffKarat",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffKarat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneName",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldDeffItemName",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    GoldWeight = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    MakingCharge = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CostPerGram = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CostForSeller = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPieces = table.Column<int>(type: "int", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Document = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<int>(type: "int", nullable: true),
                    NumberOfPiece = table.Column<int>(type: "int", nullable: true),
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
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
                    StoneCode = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<long>(type: "bigint", nullable: false),
                    WeightType = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Photo = table.Column<byte[]>(type: "image", nullable: true),
                    Document = table.Column<byte[]>(type: "image", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldStone", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffKarat");

            migrationBuilder.DropTable(
                name: "DeffStoneName");

            migrationBuilder.DropTable(
                name: "GoldDeffItemName");

            migrationBuilder.DropTable(
                name: "GoldStock");

            migrationBuilder.DropTable(
                name: "GoldStone");

            migrationBuilder.CreateTable(
                name: "DeffKaratItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffKaratItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clarity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<byte[]>(type: "image", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<byte[]>(type: "image", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<long>(type: "bigint", nullable: false),
                    WeightType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeffStoneItemCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoOrFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    StoneCode = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneItemCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnotherCode = table.Column<long>(type: "bigint", nullable: false),
                    AnotherCode2 = table.Column<long>(type: "bigint", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: true),
                    Cost = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CostForSeller = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CostPerGram = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Document = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    GoldWeight = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Karat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakingCharge = table.Column<decimal>(type: "decimal(18,3)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPiece = table.Column<int>(type: "int", nullable: true),
                    NumberOfPieces = table.Column<int>(type: "int", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxExempt = table.Column<int>(type: "int", nullable: true),
                    UserCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoldItemName",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldItemName", x => x.Id);
                });
        }
    }
}
