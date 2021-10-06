using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenPhuongThuyLinh128.Migrations
{
    public partial class NPTL0128 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NPTL0128",
                columns: table => new
                {
                    NPTLId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NPTLName = table.Column<string>(type: "TEXT", nullable: true),
                    NPTLGenre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPTL0128", x => x.NPTLId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NPTL0128");
        }
    }
}
