using API_consulta.Class;
using API_consulta.Class.Patient;
using API_consulta.Data_Base.Config;
using API_consulta.Data_Base.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace API_consulta.Data
{
    public class QueryDbContextFactory : IDesignTimeDbContextFactory<QueryDbContext>
    {
        public QueryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QueryDbContext>();
            optionsBuilder.UseSqlite("Data Source=blog.db");

            return new QueryDbContext(optionsBuilder.Options);
        }
    }

    public class QueryDbContext : DbContext

    {
        public QueryDbContext(DbContextOptions<QueryDbContext> Options)
            :base(Options)
        {

        }
        public DbSet<PatientModel> Patient { get; set; }
        public DbSet<ComorbidityModel> Comorbidity { get; set; }
        public DbSet<DrugAllergyModel> DrugAllergy { get; set; }
        public DbSet<MedicineModel> Medicine { get; set; }
        public DbSet<SymptomsModel> Symptoms { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientMap());
            modelBuilder.ApplyConfiguration(new MedicineMap());
            modelBuilder.ApplyConfiguration(new SymptomsMap());
            modelBuilder.ApplyConfiguration(new ComorbidityMap());
            modelBuilder.ApplyConfiguration(new DrugAllergyMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
