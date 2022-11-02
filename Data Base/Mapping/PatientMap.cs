using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using API_consulta.Class;

namespace API_consulta.Data_Base.Config
{
    public class PatientMap : IEntityTypeConfiguration<PatientModel>

    {
        public void Configure(EntityTypeBuilder<PatientModel> builder)
        {
            builder.ToTable("Patients");

            builder.HasKey(c => c.GetPatientId());

            builder.Property(c => c.GetPatientName()).HasMaxLength(50);

            builder.Property(c => c.GetPatientAge()).IsRequired();


        }
    }
}
