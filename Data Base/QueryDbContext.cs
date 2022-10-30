using API_consulta.Class;
using Microsoft.EntityFrameworkCore;

namespace API_consulta.Data
{
    public class QueryDbContext : DbContext

    {
        public QueryDbContext(DbContextOptions<QueryDbContext>Options)
            :base(Options)
        {

        }
        public DbSet<PatientModel> Patient { get; set; }
        public DbSet<MedicineModel> Medicine { get; set; }
        public DbSet<SymptomsModel> Symptoms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
