using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API_consulta.Class;
using API_consulta.Class.Patient;
using static API_consulta.Class.PatientModel;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace API_consulta.Data_Base.Config
{
    public class PatientMap : IEntityTypeConfiguration<PatientModel>

    {
        public void Configure(EntityTypeBuilder<PatientModel> builder)
        {
            builder.ToTable("Patient");

            builder.HasKey(PatientModel.ExpressionsPropertySimplify.PatientId);

            builder.Property(PatientModel.ExpressionsPropertySimplify.PatientName).HasMaxLength(50);

            builder.Property(PatientModel.ExpressionsPropertySimplify.PatientAge).IsRequired();

            builder.Property(PatientModel.ExpressionsPropertySimplify.PatientSex);

            builder.Property(PatientModel.ExpressionsPropertySimplify.Pregnant).IsRequired();

            builder.Property(PatientModel.ExpressionsPropertySimplify.Comorbidity).IsRequired();

            builder.Property(PatientModel.ExpressionsPropertySimplify.DrugAllergy).IsRequired();

        }
      
    }
}
