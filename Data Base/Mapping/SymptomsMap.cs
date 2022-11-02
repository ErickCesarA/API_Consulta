using API_consulta.Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_consulta.Data_Base.Mapping
{
    public class SymptomsMap : IEntityTypeConfiguration<SymptomsModel>
    {
        public void Configure(EntityTypeBuilder<SymptomsModel> builder)
        {
            builder.ToTable("Symptoms");

            builder.Property(c => c.GetSymptomsName()).IsRequired().HasMaxLength(100);

            builder.Property(c => c.GetSymptomsGravity()).IsRequired();

            builder.Property(c => c.GetSymptomsDescription()).IsRequired().HasMaxLength(1000);
        }
    }
}
