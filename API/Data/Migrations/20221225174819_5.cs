using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BarCodeType",
                table: "DeffGoldBarCode",
                newName: "BarCodeTypeEn");

            migrationBuilder.AlterColumn<float>(
                name: "BarCodeY",
                table: "DeffGoldBarCode",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BarCodeX",
                table: "DeffGoldBarCode",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BarCodeTypeAr",
                table: "DeffGoldBarCode",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarCodeTypeAr",
                table: "DeffGoldBarCode");

            migrationBuilder.RenameColumn(
                name: "BarCodeTypeEn",
                table: "DeffGoldBarCode",
                newName: "BarCodeType");

            migrationBuilder.AlterColumn<string>(
                name: "BarCodeY",
                table: "DeffGoldBarCode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "BarCodeX",
                table: "DeffGoldBarCode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
