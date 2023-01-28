using Microsoft.EntityFrameworkCore.Migrations;

namespace zad10.Migrations
{
    public partial class AddFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Studias_IdStatusNavigationIdStudia",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_IdStatusNavigationIdStudia",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IdStatusNavigationIdStudia",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdStudia",
                table: "Students",
                column: "IdStudia");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Studias_IdStudia",
                table: "Students",
                column: "IdStudia",
                principalTable: "Studias",
                principalColumn: "IdStudia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Studias_IdStudia",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_IdStudia",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "IdStatusNavigationIdStudia",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_IdStatusNavigationIdStudia",
                table: "Students",
                column: "IdStatusNavigationIdStudia");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Studias_IdStatusNavigationIdStudia",
                table: "Students",
                column: "IdStatusNavigationIdStudia",
                principalTable: "Studias",
                principalColumn: "IdStudia",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
