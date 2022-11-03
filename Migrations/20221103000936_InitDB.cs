﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_consulta.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    MedicineSymptomsCure = table.Column<string>(type: "TEXT", nullable: false),
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
                    Pregnant = table.Column<bool>(type: "INTEGER", nullable: false),
                    Comorbidity = table.Column<bool>(type: "INTEGER", nullable: false),
                    DrugAllergy = table.Column<bool>(type: "INTEGER", nullable: false)
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
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
