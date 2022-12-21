using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoneCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoneItemCategory",
                table: "StoneItemCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MadeCountrys",
                table: "MadeCountrys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KartItems",
                table: "KartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemNames",
                table: "ItemNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "DeffSupplier");

            migrationBuilder.RenameTable(
                name: "StoneItemCategory",
                newName: "StoneItemCategory");

            migrationBuilder.RenameTable(
                name: "MadeCountrys",
                newName: "DeffMadeCountry");

            migrationBuilder.RenameTable(
                name: "KartItems",
                newName: "DeffKaratItem");

            migrationBuilder.RenameTable(
                name: "ItemNames",
                newName: "GoldItemName");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "GoldCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeffSupplier",
                table: "DeffSupplier",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoneItemCategory",
                table: "StoneItemCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeffMadeCountry",
                table: "DeffMadeCountry",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeffKaratItem",
                table: "DeffKaratItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoldItemName",
                table: "GoldItemName",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoldCategory",
                table: "GoldCategory",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DeffStoneCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneCategory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffStoneCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoneItemCategory",
                table: "StoneItemCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoldItemName",
                table: "GoldItemName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoldCategory",
                table: "GoldCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeffSupplier",
                table: "DeffSupplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeffMadeCountry",
                table: "DeffMadeCountry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeffKaratItem",
                table: "DeffKaratItem");

            migrationBuilder.RenameTable(
                name: "StoneItemCategory",
                newName: "StoneItemCategory");

            migrationBuilder.RenameTable(
                name: "GoldItemName",
                newName: "ItemNames");

            migrationBuilder.RenameTable(
                name: "GoldCategory",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "DeffSupplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "DeffMadeCountry",
                newName: "MadeCountrys");

            migrationBuilder.RenameTable(
                name: "DeffKaratItem",
                newName: "KartItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoneItemCategory",
                table: "StoneItemCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemNames",
                table: "ItemNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MadeCountrys",
                table: "MadeCountrys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KartItems",
                table: "KartItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StoneCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneCategory", x => x.Id);
                });
        }
    }
}
