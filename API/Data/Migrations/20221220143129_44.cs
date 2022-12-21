using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffMadeCountry");

            migrationBuilder.RenameColumn(
                name: "PhotoOrFile",
                table: "GoldCategory",
                newName: "Photo");

            migrationBuilder.AlterColumn<int>(
                name: "TaxExempt",
                table: "GoldCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Condition",
                table: "GoldCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Document",
                table: "GoldCategory",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Clarity",
                table: "DeffStoneCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "DeffStoneCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryOfOrigin",
                table: "DeffStoneCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cut",
                table: "DeffStoneCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Document",
                table: "DeffStoneCategory",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "DeffStoneCategory",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "DeffStoneCategory",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "DeffStoneCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Weight",
                table: "DeffStoneCategory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "WeightType",
                table: "DeffStoneCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeffCountryOfOrigin",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffCountryOfOrigin", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffCountryOfOrigin");

            migrationBuilder.DropColumn(
                name: "Condition",
                table: "GoldCategory");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "GoldCategory");

            migrationBuilder.DropColumn(
                name: "Clarity",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "CountryOfOrigin",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "Cut",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "DeffStoneCategory");

            migrationBuilder.DropColumn(
                name: "WeightType",
                table: "DeffStoneCategory");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "GoldCategory",
                newName: "PhotoOrFile");

            migrationBuilder.AlterColumn<bool>(
                name: "TaxExempt",
                table: "GoldCategory",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DeffMadeCountry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffMadeCountry", x => x.Id);
                });
        }
    }
}
