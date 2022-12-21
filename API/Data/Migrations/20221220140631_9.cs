using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoneItemCategory");

            migrationBuilder.CreateTable(
                name: "DeffStoneItemCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
                    StoneCode = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    PhotoOrFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeffStoneItemCategory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeffStoneItemCategory");

            migrationBuilder.CreateTable(
                name: "StoneItemCategory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryCode = table.Column<long>(type: "bigint", nullable: false),
                    Colour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoOrFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    StoneCode = table.Column<long>(type: "bigint", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneItemCategory", x => x.Id);
                });
        }
    }
}
