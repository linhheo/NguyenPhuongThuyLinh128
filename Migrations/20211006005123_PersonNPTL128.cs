using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenPhuongThuyLinh128.Migrations
{
    public partial class PersonNPTL128 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonNPTL128",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "varchar(20)", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonName = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonNPTL128", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonNPTL128");
        }
    }
}
