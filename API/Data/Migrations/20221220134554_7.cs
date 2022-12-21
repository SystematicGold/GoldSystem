using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "Category",
                newName: "GoldWeight");

            migrationBuilder.RenameColumn(
                name: "Ramz",
                table: "Category",
                newName: "Symbol");

            migrationBuilder.RenameColumn(
                name: "NumberPiece",
                table: "Category",
                newName: "NumberOfPiece");

            migrationBuilder.RenameColumn(
                name: "MadeIn",
                table: "Category",
                newName: "Karat");

            migrationBuilder.RenameColumn(
                name: "Kart",
                table: "Category",
                newName: "CountryOfOrigin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Symbol",
                table: "Category",
                newName: "Ramz");

            migrationBuilder.RenameColumn(
                name: "NumberOfPiece",
                table: "Category",
                newName: "NumberPiece");

            migrationBuilder.RenameColumn(
                name: "Karat",
                table: "Category",
                newName: "MadeIn");

            migrationBuilder.RenameColumn(
                name: "GoldWeight",
                table: "Category",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "CountryOfOrigin",
                table: "Category",
                newName: "Kart");
        }
    }
}
