using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApp.Data.Migrations
{
    public partial class addExtenstionEmployeeSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Firstname", "Interest", "Lastname" },
                values: new object[] { 4, "80th DownTown Street, Rebel, 98000", 24, "Laura", "Skydiving", "Reed" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Firstname", "Interest", "Lastname" },
                values: new object[] { 5, "45 W 6th S, Village Lane, 670891", 20, "Johnny", "Swimming, Politics", "Lott" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Firstname", "Interest", "Lastname" },
                values: new object[] { 6, " #12 Ifako Str, Nigeria, 400467", 29, "JoAnn", "soccer, Binge watching movies", "Orezi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
