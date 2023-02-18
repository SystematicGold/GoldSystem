using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class zz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "DeffPayMethod");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DeffStoneName",
                newName: "NameEn");

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "GoldDeffItemName",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffTaxExempt",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffSupplier",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffStoneName",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "DeffStoneName",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoneTypeCode",
                table: "DeffStoneName",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffStoneColor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffPayMethod",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffKarat",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "DeffCountryOfOrigin",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffStoneType");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "GoldDeffItemName");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffTaxExempt");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffSupplier");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffStoneName");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "DeffStoneName");

            migrationBuilder.DropColumn(
                name: "StoneTypeCode",
                table: "DeffStoneName");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffStoneColor");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffPayMethod");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffKarat");

            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "DeffCountryOfOrigin");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "DeffStoneName",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DeffPayMethod",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
