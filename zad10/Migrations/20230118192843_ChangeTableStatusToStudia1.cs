using Microsoft.EntityFrameworkCore.Migrations;

namespace zad10.Migrations
{
    public partial class ChangeTableStatusToStudia1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Statuses_IdStatusNavigationIdStudia",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Studias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studias",
                table: "Studias",
                column: "IdStudia");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Studias_IdStatusNavigationIdStudia",
                table: "Students",
                column: "IdStatusNavigationIdStudia",
                principalTable: "Studias",
                principalColumn: "IdStudia",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Studias_IdStatusNavigationIdStudia",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Studias",
                table: "Studias");

            migrationBuilder.RenameTable(
                name: "Studias",
                newName: "Statuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "IdStudia");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Statuses_IdStatusNavigationIdStudia",
                table: "Students",
                column: "IdStatusNavigationIdStudia",
                principalTable: "Statuses",
                principalColumn: "IdStudia",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
