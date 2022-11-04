using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API_consulta.Class;
using API_consulta.Class.Patient;
using static API_consulta.Class.PatientModel;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_consulta.Data_Base.Config
{
    public class ComorbidityMap : IEntityTypeConfiguration<ComorbidityModel>

    {
        public void Configure(EntityTypeBuilder<ComorbidityModel> builder)
        {
            builder.ToTable("Comorbidity");

            builder.HasKey(ComorbidityModel.ExpressionsPropertySimplify.ComorbidityId);

            builder.Property(ComorbidityModel.ExpressionsPropertySimplify.ComorbidityName).HasMaxLength(50).IsRequired();

            builder.Property(ComorbidityModel.ExpressionsPropertySimplify.ComorbidityDescription).HasMaxLength(2000);
        }
    }
}

