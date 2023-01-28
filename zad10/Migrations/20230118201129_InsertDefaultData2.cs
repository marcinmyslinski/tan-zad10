using Microsoft.EntityFrameworkCore.Migrations;

namespace zad10.Migrations
{
    public partial class InsertDefaultData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studias",
                columns: new[] { "IdStudia", "Nazwa", "Tryb" },
                values: new object[] { 1, "Filozofia", "Dzienny" });

            migrationBuilder.InsertData(
                table: "Studias",
                columns: new[] { "IdStudia", "Nazwa", "Tryb" },
                values: new object[] { 2, "Ekonomia", "Dzienny" });

            migrationBuilder.InsertData(
                table: "Studias",
                columns: new[] { "IdStudia", "Nazwa", "Tryb" },
                values: new object[] { 3, "Informatyka", "Dzienny" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "IdStudia", "Imie", "Nazwisko", "NrIndeksu", "RokStudiow" },
                values: new object[,]
                {
                    { 1, 1, "Marcin", "Rawa", "11", 5 },
                    { 2, 1, "Anna", "Tobiasz", "12", 4 },
                    { 3, 2, "Marcin", "Krasuski", "13", 3 },
                    { 4, 3, "Tomasz", "Sieciechowicz", "14", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Studias",
                keyColumn: "IdStudia",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studias",
                keyColumn: "IdStudia",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Studias",
                keyColumn: "IdStudia",
                keyValue: 3);
        }
    }
}
