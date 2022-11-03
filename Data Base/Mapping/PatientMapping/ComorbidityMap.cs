//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using API_consulta.Class;
//using API_consulta.Class.Patient;
//using static API_consulta.Class.PatientModel;
//using System.Reflection.Emit;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace API_consulta.Data_Base.Config
//{
//    public class ComorbidityMap : IEntityTypeConfiguration<WhichComorbidityModel>

//    {
//        public void Configure(EntityTypeBuilder<WhichComorbidityModel> builder)
//        {
//            builder.ToTable("Comorbidity");

//            builder.Property(WhichComorbidityModel.ExpressionsPropertySimplify.ComorbidityName).HasMaxLength(50).IsRequired();
//            builder.Property(WhichComorbidityModel.ExpressionsPropertySimplify.ComorbidityDescription).HasMaxLength(2000);
//        }
//    }
//}

