using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    public partial class test14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "MedicalEducationNumber", "Name" },
                values: new object[] { 1, "1354698", "احمد ذوقی" });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "MedicalEducationNumber", "Name" },
                values: new object[] { 2, "1242456", "2احمد ذوقی" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
