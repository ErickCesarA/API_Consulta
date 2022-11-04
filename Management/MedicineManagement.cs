using API_consulta.Class;
using API_consulta.Data;
using API_consulta.Management.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_consulta.Management
{
    public class MedicineManagement : IMedicineManagement
    {
        private readonly QueryDbContext _dbContext;
        public MedicineManagement(QueryDbContext QueryDbContext)
        {
            _dbContext = QueryDbContext;
        }
        public async Task<MedicineModel> SerchMedicineId(int medicine_id)
        {
            return  await _dbContext.Medicine.FirstOrDefaultAsync(finder => finder.GetMedicineId() == medicine_id);
        }
        public async Task<List<MedicineModel>> GetAllMedicine()
        {
            return await _dbContext.Medicine.ToListAsync();
        }

        public async Task<MedicineModel> AddMedicine(MedicineModel Medicine)
        {
           await _dbContext.Medicine.AddAsync(Medicine);
            await _dbContext.SaveChangesAsync();
             return Medicine; 
        }

        public async Task<bool> DelMedicine(int medicine_id)
        {
            MedicineModel FoundMedicine = await SerchMedicineId(medicine_id);
            if (FoundMedicine == null)
            {
                throw new Exception("Patient not found");
            }
            _dbContext.Medicine.Remove(FoundMedicine);
            await _dbContext.SaveChangesAsync();

            return true;

        }
    }
}
