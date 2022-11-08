﻿// <auto-generated />
using API_consulta.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_consulta.Migrations
{
    [DbContext(typeof(QueryDbContext))]
    [Migration("20221104141421_SqlServerDB")]
    partial class SqlServerDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_consulta.Class.MedicineModel", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"), 1L, 1);

                    b.Property<int>("MedicineAgeUse")
                        .HasColumnType("int");

                    b.Property<int>("MedicineMg")
                        .HasColumnType("int");

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MedicinePillNumber")
                        .HasColumnType("int");

                    b.Property<int>("MedicineSeverity")
                        .HasColumnType("int");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicine", (string)null);
                });

            modelBuilder.Entity("API_consulta.Class.Patient.ComorbidityModel", b =>
                {
                    b.Property<int>("ComorbidityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComorbidityId"), 1L, 1);

                    b.Property<string>("ComorbidityDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("ComorbidityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ComorbidityId");

                    b.ToTable("Comorbidity", (string)null);
                });

            modelBuilder.Entity("API_consulta.Class.Patient.DrugAllergyModel", b =>
                {
                    b.Property<int>("AllergyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllergyId"), 1L, 1);

                    b.Property<string>("AllergyDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("AllergyName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AllergyId");

                    b.ToTable("Allergy", (string)null);
                });

            modelBuilder.Entity("API_consulta.Class.PatientModel", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"), 1L, 1);

                    b.Property<bool>("Comorbidity")
                        .HasColumnType("bit");

                    b.Property<bool>("DrugAllergy")
                        .HasColumnType("bit");

                    b.Property<int>("PatientAge")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PatientSex")
                        .HasColumnType("int");

                    b.Property<bool>("Pregnant")
                        .HasColumnType("bit");

                    b.HasKey("PatientId");

                    b.ToTable("Patient", (string)null);
                });

            modelBuilder.Entity("API_consulta.Class.SymptomsModel", b =>
                {
                    b.Property<int>("SymptomsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SymptomsId"), 1L, 1);

                    b.Property<string>("SymptomsDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("SymptomsGravity")
                        .HasColumnType("int");

                    b.Property<string>("SymptomsName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SymptomsId");

                    b.ToTable("Symptoms", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}