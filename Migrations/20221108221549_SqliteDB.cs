using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_consulta.Migrations
{
    public partial class SqliteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergy",
                columns: table => new
                {
                    AllergyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AllergyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    AllergyDescription = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergy", x => x.AllergyId);
                });

            migrationBuilder.CreateTable(
                name: "Comorbidity",
                columns: table => new
                {
                    ComorbidityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComorbidityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ComorbidityDescription = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comorbidity", x => x.ComorbidityId);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MedicineName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MedicineMg = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicinePillNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineAgeUse = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineSeverity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.MedicineId);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PatientAge = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientSex = table.Column<int>(type: "INTEGER", nullable: false),
                    Pregnant = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    SymptomsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SymptomsName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    SymptomsGravity = table.Column<int>(type: "INTEGER", nullable: false),
                    SymptomsDescription = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.SymptomsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allergy");

            migrationBuilder.DropTable(
                name: "Comorbidity");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
