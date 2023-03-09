using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _0س0ي : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeightType",
                table: "GoldStone",
                newName: "StoneWeightType");

            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "GoldStone",
                newName: "StoneWeight");

            migrationBuilder.RenameColumn(
                name: "TypeCode",
                table: "GoldStone",
                newName: "StoneTypeCode");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "GoldStone",
                newName: "StonePrice");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "GoldStone",
                newName: "StonePhoto");

            migrationBuilder.RenameColumn(
                name: "Document",
                table: "GoldStone",
                newName: "StoneDocument");

            migrationBuilder.RenameColumn(
                name: "Cut",
                table: "GoldStone",
                newName: "StoneCut");

            migrationBuilder.RenameColumn(
                name: "CountryOfOrigin",
                table: "GoldStone",
                newName: "StoneCountryOfOrigin");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "GoldStone",
                newName: "StoneColor");

            migrationBuilder.RenameColumn(
                name: "Clarity",
                table: "GoldStone",
                newName: "StoneClarity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StoneWeightType",
                table: "GoldStone",
                newName: "WeightType");

            migrationBuilder.RenameColumn(
                name: "StoneWeight",
                table: "GoldStone",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "StoneTypeCode",
                table: "GoldStone",
                newName: "TypeCode");

            migrationBuilder.RenameColumn(
                name: "StonePrice",
                table: "GoldStone",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "StonePhoto",
                table: "GoldStone",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "StoneDocument",
                table: "GoldStone",
                newName: "Document");

            migrationBuilder.RenameColumn(
                name: "StoneCut",
                table: "GoldStone",
                newName: "Cut");

            migrationBuilder.RenameColumn(
                name: "StoneCountryOfOrigin",
                table: "GoldStone",
                newName: "CountryOfOrigin");

            migrationBuilder.RenameColumn(
                name: "StoneColor",
                table: "GoldStone",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "StoneClarity",
                table: "GoldStone",
                newName: "Clarity");
        }
    }
}
