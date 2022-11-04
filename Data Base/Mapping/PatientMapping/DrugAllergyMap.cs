using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API_consulta.Class;
using API_consulta.Class.Patient;
using static API_consulta.Class.PatientModel;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_consulta.Data_Base.Config
{
    public class DrugAllergyMap : IEntityTypeConfiguration<DrugAllergyModel>

    {
        public void Configure(EntityTypeBuilder<DrugAllergyModel> builder)
        {
            builder.ToTable("Allergy");

            builder.HasKey(DrugAllergyModel.ExpressionsPropertySimplify.AllergyId);

            builder.Property(DrugAllergyModel.ExpressionsPropertySimplify.AllergyName).HasMaxLength(50).IsRequired();

            builder.Property(DrugAllergyModel.ExpressionsPropertySimplify.AllergyDescription).HasMaxLength(2000);
        }
    }
}