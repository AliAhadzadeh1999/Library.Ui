using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Infrastructure.Migrations
{
    public partial class test21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    MedicalEducationNumber = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laboratory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radiology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpireDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceTypeId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_InsuranceType_InsuranceTypeId",
                        column: x => x.InsuranceTypeId,
                        principalTable: "InsuranceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Insurance_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescription_Doctor_DrId",
                        column: x => x.DrId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prescription_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoginAccess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginAccess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginAccess_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "PrescriptionMedicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionMedicine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicine_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionMedicine_Prescription_PrescriptionId",
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
                    RadiologyId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_PrescriptionRadiology_Radiology_RadiologyId",
                        column: x => x.RadiologyId,
                        principalTable: "Radiology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "InsuranceType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "تامین اجتماعی" },
                    { 2, "سلامت" }
                });

            migrationBuilder.InsertData(
                table: "Medicine",
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
                table: "Radiology",
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

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_InsuranceTypeId",
                table: "Insurance",
                column: "InsuranceTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_PersonId",
                table: "Insurance",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_DrId",
                table: "Prescription",
                column: "DrId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_PersonId",
                table: "Prescription",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionLaboratory_LaboratoryTypeId",
                table: "PrescriptionLaboratory",
                column: "LaboratoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionLaboratory_PrescriptionId",
                table: "PrescriptionLaboratory",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicine_MedicineId",
                table: "PrescriptionMedicine",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionMedicine_PrescriptionId",
                table: "PrescriptionMedicine",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionRadiology_PrescriptionId",
                table: "PrescriptionRadiology",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionRadiology_RadiologyId",
                table: "PrescriptionRadiology",
                column: "RadiologyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "LoginAccess");

            migrationBuilder.DropTable(
                name: "PrescriptionLaboratory");

            migrationBuilder.DropTable(
                name: "PrescriptionMedicine");

            migrationBuilder.DropTable(
                name: "PrescriptionRadiology");

            migrationBuilder.DropTable(
                name: "InsuranceType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Laboratory");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "Radiology");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
