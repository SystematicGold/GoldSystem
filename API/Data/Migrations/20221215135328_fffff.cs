using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class fffff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Making",
                table: "Category",
                newName: "MakingCharge");

            migrationBuilder.RenameColumn(
                name: "Making",
                table: "AnotherPiece",
                newName: "MakingCharge");

            migrationBuilder.RenameColumn(
                name: "Making",
                table: "AnotherAnotherCategory",
                newName: "MakingCharge");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MakingCharge",
                table: "Category",
                newName: "Making");

            migrationBuilder.RenameColumn(
                name: "MakingCharge",
                table: "AnotherPiece",
                newName: "Making");

            migrationBuilder.RenameColumn(
                name: "MakingCharge",
                table: "AnotherAnotherCategory",
                newName: "Making");
        }
    }
}
