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

            builder.HasKey(MedicineModel.ExpressionsPropertySimplify.MedicineId);

            builder.Property(MedicineModel.ExpressionsPropertySimplify.MedicineName).IsRequired().HasMaxLength(100);

            builder.Property(MedicineModel.ExpressionsPropertySimplify.MedicineMg).IsRequired();

            builder.Property(MedicineModel.ExpressionsPropertySimplify.MedicinePillNumber).IsRequired();

            builder.Property(MedicineModel.ExpressionsPropertySimplify.MedicineAgeUse).IsRequired();

            builder.Property(MedicineModel.ExpressionsPropertySimplify.MedicineSeverity).IsRequired();
            
        }

    }
}
    