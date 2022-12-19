using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _9999 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CostForSeller",
                table: "Category",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfManufacture",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TaxExempt",
                table: "Category",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostForSeller",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DateOfManufacture",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "TaxExempt",
                table: "Category");
        }
    }
}
