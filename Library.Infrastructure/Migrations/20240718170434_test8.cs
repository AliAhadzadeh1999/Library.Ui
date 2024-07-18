using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    public partial class test8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsuranceType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "تامین اجتماعی" },
                    { 2, "سلامت" }
                });

            migrationBuilder.InsertData(
                table: "MedicineType",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "استامینوفن", 0L },
                    { 2, "ژلوفن", 0L },
                    { 3, "پروفن", 0L }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "DateOfBirth", "Family", "FatherName", "Name", "NationalId" },
                values: new object[] { 1, "13780624", "احدزاده", "عادل", "علی", "0312020244" });

            migrationBuilder.InsertData(
                table: "RadiologyType",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "استخوان", 0L },
                    { 2, "اعضای داخلی", 0L },
                    { 3, "غضروف", 0L }
                });

            migrationBuilder.InsertData(
                table: "Insurance",
                columns: new[] { "Id", "ExpireDate", "InsuranceTypeId", "PersonId", "StartDate" },
                values: new object[] { 1, "14020509", 1, 1, "14010509" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurance",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsuranceType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicineType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicineType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicineType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RadiologyType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RadiologyType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RadiologyType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsuranceType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
