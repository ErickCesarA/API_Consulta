using API_consulta.Data;
using API_consulta.Management;
using API_consulta.Management.Interface;
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

            var app = builder.Build();

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<QueryDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddScoped<IPatientManagement, PatientManagement>();
            builder.Services.AddScoped<IMedicineManagement, MedicineManagement>();
            builder.Services.AddScoped<ISymptomsManagements, SymptomsManagement>();


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