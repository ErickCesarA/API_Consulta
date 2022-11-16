using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_consulta.Migrations
{
    public partial class StartDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergy",
                columns: table => new
                {
                    AllergyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    //allergyId = table.Column<int>(type: "INTEGER", nullable: false),
                    //allergyName = table.Column<string>(type: "TEXT", nullable: true),
                    //allergyDescription = table.Column<string>(type: "TEXT", nullable: true),
                    AllergyDescription = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    AllergyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
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
                    //comorbidityId = table.Column<int>(type: "INTEGER", nullable: false),
                    //comorbidityName = table.Column<string>(type: "TEXT", nullable: true),
                    //comorbidityDescription = table.Column<string>(type: "TEXT", nullable: true),
                    ComorbidityDescription = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    ComorbidityName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
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
                    //medicineId = table.Column<int>(type: "INTEGER", nullable: false),
                    //medicineName = table.Column<string>(type: "TEXT", nullable: true),
                    //medicineMg = table.Column<int>(type: "INTEGER", nullable: false),
                    //medicinePillNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    //medicineAgeUse = table.Column<int>(type: "INTEGER", nullable: false),
                    //medicineSeverity = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineAgeUse = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineMg = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicineName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MedicinePillNumber = table.Column<int>(type: "INTEGER", nullable: false),
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
                    //patientId = table.Column<int>(type: "INTEGER", nullable: false),
                    //patientName = table.Column<string>(type: "TEXT", nullable: true),
                    //patientAge = table.Column<int>(type: "INTEGER", nullable: false),
                    //patientSex = table.Column<int>(type: "INTEGER", nullable: false),
                    //pregnant = table.Column<bool>(type: "INTEGER", nullable: false),
                    //comorbidity = table.Column<bool>(type: "INTEGER", nullable: false),
                    //drugAllergy = table.Column<bool>(type: "INTEGER", nullable: false),
                    Comorbidity = table.Column<bool>(type: "INTEGER", nullable: false),
                    DrugAllergy = table.Column<bool>(type: "INTEGER", nullable: false),
                    PatientAge = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
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
                    //symptomsId = table.Column<int>(type: "INTEGER", nullable: false),
                    //symptomsName = table.Column<string>(type: "TEXT", nullable: true),
                    //symptomsGravity = table.Column<int>(type: "INTEGER", nullable: false),
                    //symptomsDescription = table.Column<string>(type: "TEXT", nullable: true),
                    SymptomsDescription = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    SymptomsGravity = table.Column<int>(type: "INTEGER", nullable: false),
                    SymptomsName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
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
