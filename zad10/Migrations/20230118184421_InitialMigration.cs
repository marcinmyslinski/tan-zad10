using Microsoft.EntityFrameworkCore.Migrations;

namespace zad10.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    IdStudia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tryb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.IdStudia);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NrIndeksu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RokStudiow = table.Column<int>(type: "int", nullable: false),
                    IdStudia = table.Column<int>(type: "int", nullable: false),
                    IdStatusNavigationIdStudia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                    table.ForeignKey(
                        name: "FK_Students_Statuses_IdStatusNavigationIdStudia",
                        column: x => x.IdStatusNavigationIdStudia,
                        principalTable: "Statuses",
                        principalColumn: "IdStudia",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdStatusNavigationIdStudia",
                table: "Students",
                column: "IdStatusNavigationIdStudia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
