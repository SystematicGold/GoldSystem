using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class fffdddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberPieces",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "NumberPieces",
                table: "AnotherPiece");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AnotherPiece");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AnotherAnotherCategory");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Category",
                newName: "PhotoOrFile");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "AnotherPiece",
                newName: "PhotoOrFile");

            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "AnotherAnotherCategory",
                newName: "PhotoOrFile");

            migrationBuilder.RenameColumn(
                name: "NumberPieces",
                table: "AnotherAnotherCategory",
                newName: "NumberPiece");

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoOrFile",
                table: "StoneCategory",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Supplier",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPieces",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberPiece",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ramz",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Supplier",
                table: "AnotherPiece",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPieces",
                table: "AnotherPiece",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberPiece",
                table: "AnotherPiece",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ramz",
                table: "AnotherPiece",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Supplier",
                table: "AnotherAnotherCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPieces",
                table: "AnotherAnotherCategory",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ramz",
                table: "AnotherAnotherCategory",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoOrFile",
                table: "StoneCategory");

            migrationBuilder.DropColumn(
                name: "NumberOfPieces",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "NumberPiece",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Ramz",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "NumberOfPieces",
                table: "AnotherPiece");

            migrationBuilder.DropColumn(
                name: "NumberPiece",
                table: "AnotherPiece");

            migrationBuilder.DropColumn(
                name: "Ramz",
                table: "AnotherPiece");

            migrationBuilder.DropColumn(
                name: "NumberOfPieces",
                table: "AnotherAnotherCategory");

            migrationBuilder.DropColumn(
                name: "Ramz",
                table: "AnotherAnotherCategory");

            migrationBuilder.RenameColumn(
                name: "PhotoOrFile",
                table: "Category",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "PhotoOrFile",
                table: "AnotherPiece",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "PhotoOrFile",
                table: "AnotherAnotherCategory",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "NumberPiece",
                table: "AnotherAnotherCategory",
                newName: "NumberPieces");

            migrationBuilder.AlterColumn<string>(
                name: "Supplier",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "NumberPieces",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Supplier",
                table: "AnotherPiece",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "NumberPieces",
                table: "AnotherPiece",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "AnotherPiece",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Supplier",
                table: "AnotherAnotherCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "AnotherAnotherCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
