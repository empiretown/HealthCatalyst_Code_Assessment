using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class ExtensionEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Firstname", "Interest", "Lastname" },
                values: new object[] { 1, "59th 11th Street, Turkey, 780002", 30, "Jordan", "Golfing", "Alohan" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Firstname", "Interest", "Lastname" },
                values: new object[] { 2, "249 Hilltop Street,Belgium, 80002-12", 20, "Johnny", "Skiing", "Belizuk" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Firstname", "Interest", "Lastname" },
                values: new object[] { 3, " #1 Transcorp Hill Road, Nigeria, 450232", 45, "Janet", "Skiing", "Ohakwe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
