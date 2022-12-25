using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "GoldStone",
                newName: "UserCode");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "GoldStone",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "GoldStone",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "image",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Document",
                table: "GoldStone",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "image",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "MakingCharge",
                table: "GoldStock",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<double>(
                name: "GoldWeight",
                table: "GoldStock",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<double>(
                name: "CostPerGram",
                table: "GoldStock",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<double>(
                name: "CostForSeller",
                table: "GoldStock",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

            migrationBuilder.AlterColumn<double>(
                name: "Cost",
                table: "GoldStock",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserCode",
                table: "GoldStone",
                newName: "UserID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "GoldStone",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "GoldStone",
                type: "image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Document",
                table: "GoldStone",
                type: "image",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MakingCharge",
                table: "GoldStock",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "GoldWeight",
                table: "GoldStock",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostPerGram",
                table: "GoldStock",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "CostForSeller",
                table: "GoldStock",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Cost",
                table: "GoldStock",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
