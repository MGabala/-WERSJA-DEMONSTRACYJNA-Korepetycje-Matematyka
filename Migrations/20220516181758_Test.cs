using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Korepetycje_Matematyka.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Desc = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terminy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dzień_Tygodnia = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina1 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina2 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina3 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina4 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina5 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina6 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina7 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina8 = table.Column<string>(type: "TEXT", nullable: false),
                    Godzina9 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminy", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Terminy");
        }
    }
}
