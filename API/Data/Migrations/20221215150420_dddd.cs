using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class dddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnotherAnotherCategory");

            migrationBuilder.DropTable(
                name: "AnotherPiece");

            migrationBuilder.AddColumn<long>(
                name: "AnotherCode",
                table: "Category",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AnotherCode2",
                table: "Category",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnotherCode",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "AnotherCode2",
                table: "Category");

            migrationBuilder.CreateTable(
                name: "AnotherAnotherCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnotherCode = table.Column<long>(type: "bigint", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    CostPerGram = table.Column<float>(type: "real", nullable: false),
                    Kart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakingCharge = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPieces = table.Column<int>(type: "int", nullable: true),
                    NumberPiece = table.Column<int>(type: "int", nullable: true),
                    PhotoOrFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Ramz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotherAnotherCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnotherPiece",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesCode = table.Column<long>(type: "bigint", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    CostPerGram = table.Column<float>(type: "real", nullable: false),
                    Kart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MadeIn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakingCharge = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPieces = table.Column<int>(type: "int", nullable: true),
                    NumberPiece = table.Column<int>(type: "int", nullable: true),
                    PhotoOrFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Ramz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnotherPiece", x => x.Id);
                });
        }
    }
}
