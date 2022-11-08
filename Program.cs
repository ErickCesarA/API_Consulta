using API_consulta.Data;
using API_consulta.Management;
using API_consulta.Management.Interface;
using API_consulta.Management.Interface.PatientInterface;
using API_consulta.Management.Patient_Management;
using API_consulta.Managemet.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_consulta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkSqlite()
                .AddDbContext<QueryDbContext>(
                options => options.UseSqlite(builder.Configuration.GetConnectionString("QueryDataBase"))
                );

            builder.Services.AddScoped<IPatientManagement, PatientManagement>();
            builder.Services.AddScoped<IDrugAllergyManagement, DrugAllergyManagement>();
            builder.Services.AddScoped<IComorbidityManagement, ComorbidityManagement>();
            builder.Services.AddScoped<IMedicineManagement, MedicineManagement>();
            builder.Services.AddScoped<ISymptomsManagements, SymptomsManagement>();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}