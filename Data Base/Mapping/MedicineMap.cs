using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API_consulta.Class;

namespace API_consulta.Data_Base.Config
{
    public class MedicineMap : IEntityTypeConfiguration<MedicineModel>
    {
        public void Configure(EntityTypeBuilder<MedicineModel> builder)
        {
            builder.ToTable("Medicine");

            builder.HasKey(c => c.GetMedicineId());

            builder.Property(c => c.GetMedicineName()).IsRequired().HasMaxLength(100);

            builder.Property(c => c.GetMedicineMg()).IsRequired();

            builder.Property(c => c.GetMedicinePillNumber()).IsRequired();

            builder.Property(c => c.GetMedicineAgeUse()).IsRequired();

            builder.Property(c => c.GetMedicineSeverity()).IsRequired();

        }

    }
}
    