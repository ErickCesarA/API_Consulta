using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API_consulta.Class;
using API_consulta.Class.Patient;
using static API_consulta.Class.PatientModel;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_consulta.Data_Base.Config
{
    public class DrugAllergyMap : IEntityTypeConfiguration<WhichDrugAllergyModel>

    {
        public void Configure(EntityTypeBuilder<WhichDrugAllergyModel> builder)
        {
            builder.ToTable("Allergy");

            builder.Property(WhichDrugAllergyModel.ExpressionsPropertySimplify.ComorbidityName).HasMaxLength(50).IsRequired();
            builder.Property(WhichDrugAllergyModel.ExpressionsPropertySimplify.ComorbidityDescription).HasMaxLength(2000);
        }
    }
}