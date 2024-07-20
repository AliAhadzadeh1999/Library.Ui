using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    public partial class test11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laboratory_LaboratoryType_LaboratoryTypeId",
                table: "Laboratory");

            migrationBuilder.DropForeignKey(
                name: "FK_Laboratory_Prescription_PrescriptionId",
                table: "Laboratory");

            migrationBuilder.DropForeignKey(
                name: "FK_Radiology_Prescription_PrescriptionId",
                table: "Radiology");

            migrationBuilder.DropForeignKey(
                name: "FK_Radiology_RadiologyType_RadiologyTypeId",
                table: "Radiology");

            migrationBuilder.DropTable(
                name: "LaboratoryType");

            migrationBuilder.DropTable(
                name: "RadiologyType");

            migrationBuilder.DropIndex(
                name: "IX_Radiology_PrescriptionId",
                table: "Radiology");

            migrationBuilder.DropIndex(
                name: "IX_Radiology_RadiologyTypeId",
                table: "Radiology");

            migrationBuilder.DropIndex(
                name: "IX_Laboratory_LaboratoryTypeId",
                table: "Laboratory");

            migrationBuilder.DropIndex(
                name: "IX_Laboratory_PrescriptionId",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Radiology");

            migrationBuilder.DropColumn(
                name: "RadiologyTypeId",
                table: "Radiology");

            migrationBuilder.DropColumn(
                name: "LaboratoryTypeId",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Laboratory");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Radiology",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Radiology",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Laboratory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Laboratory",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "PrescriptionLaboratory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    LaboratoryTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionLaboratory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionLaboratory_Laboratory_LaboratoryTypeId",
                        column: x => x.LaboratoryTypeId,
                        principalTable: "Laboratory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionLaboratory_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionRadiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    RadiologyTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionRadiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionRadiology_Prescription_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionRadiology_Radiology_RadiologyTypeId",
                        column: x => x.RadiologyTypeId,
                        principalTable: "Radiology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Radiology",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "استخوان", 0L });

            migrationBuilder.InsertData(
                table: "Radiology",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "اعضای داخلی", 0L });

            migrationBuilder.InsertData(
                table: "Radiology",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "غضروف", 0L });

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionLaboratory_LaboratoryTypeId",
                table: "PrescriptionLaboratory",
                column: "LaboratoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionLaboratory_PrescriptionId",
                table: "PrescriptionLaboratory",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionRadiology_PrescriptionId",
                table: "PrescriptionRadiology",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionRadiology_RadiologyTypeId",
                table: "PrescriptionRadiology",
                column: "RadiologyTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescriptionLaboratory");

            migrationBuilder.DropTable(
                name: "PrescriptionRadiology");

            migrationBuilder.DeleteData(
                table: "Radiology",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Radiology",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Radiology",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Radiology");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Radiology");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Laboratory");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Laboratory");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Radiology",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RadiologyTypeId",
                table: "Radiology",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaboratoryTypeId",
                table: "Laboratory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Laboratory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LaboratoryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaboratoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RadiologyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadiologyType", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RadiologyType",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "استخوان", 0L });

            migrationBuilder.InsertData(
                table: "RadiologyType",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "اعضای داخلی", 0L });

            migrationBuilder.InsertData(
                table: "RadiologyType",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "غضروف", 0L });

            migrationBuilder.CreateIndex(
                name: "IX_Radiology_PrescriptionId",
                table: "Radiology",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Radiology_RadiologyTypeId",
                table: "Radiology",
                column: "RadiologyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratory_LaboratoryTypeId",
                table: "Laboratory",
                column: "LaboratoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratory_PrescriptionId",
                table: "Laboratory",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratory_LaboratoryType_LaboratoryTypeId",
                table: "Laboratory",
                column: "LaboratoryTypeId",
                principalTable: "LaboratoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Laboratory_Prescription_PrescriptionId",
                table: "Laboratory",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radiology_Prescription_PrescriptionId",
                table: "Radiology",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Radiology_RadiologyType_RadiologyTypeId",
                table: "Radiology",
                column: "RadiologyTypeId",
                principalTable: "RadiologyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
