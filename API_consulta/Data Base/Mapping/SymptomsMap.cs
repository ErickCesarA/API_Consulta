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

            builder.HasKey(SymptomsModel.ExpressionsPropertySimplify.SymptomsId);

            builder.Property(SymptomsModel.ExpressionsPropertySimplify.SymptomsName).IsRequired().HasMaxLength(100);

            builder.Property(SymptomsModel.ExpressionsPropertySimplify.SymptomsGravity).IsRequired();

            builder.Property(SymptomsModel.ExpressionsPropertySimplify.SymptomsDescription).IsRequired().HasMaxLength(1000);
        }
    }
}
