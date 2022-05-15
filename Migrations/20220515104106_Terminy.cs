using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Korepetycje_Matematyka.Migrations
{
    public partial class Terminy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terminy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Poniedziałek = table.Column<string>(type: "TEXT", nullable: false),
                    Wtorek = table.Column<string>(type: "TEXT", nullable: false),
                    Środa = table.Column<string>(type: "TEXT", nullable: false),
                    Czwartek = table.Column<string>(type: "TEXT", nullable: false),
                    Piątek = table.Column<string>(type: "TEXT", nullable: false),
                    Sobota = table.Column<string>(type: "TEXT", nullable: false),
                    Niedziela = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminy", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terminy");
        }
    }
}
