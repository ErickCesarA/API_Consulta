using API_consulta.Class.Patient;
using API_consulta.Data;
using API_consulta.Management.Interface.PatientInterface;
using Microsoft.EntityFrameworkCore;

namespace API_consulta.Management.Patient_Management
{
    public class DrugAllergyManagement : IDrugAllergyManagement
    {
        private readonly QueryDbContext _dbContext;
        public DrugAllergyManagement(QueryDbContext QueryDbContext)
        {
            _dbContext = QueryDbContext;
        }
        public async Task<List<DrugAllergyModel>> GetAllAllergy()
        {
            return await _dbContext.DrugAllergy.ToListAsync();
        }
        public async Task<DrugAllergyModel> SerchAllergyId(int drug_allergy_id)
        {
            return await _dbContext.DrugAllergy.FirstOrDefaultAsync(finder => finder.GetAllergyId() == drug_allergy_id);
        }
        public async Task<DrugAllergyModel> AddAllergy(DrugAllergyModel drug_allergy)
        {
            await _dbContext.DrugAllergy.AddAsync(drug_allergy);
            await _dbContext.SaveChangesAsync();
            return drug_allergy;
        }

        public async Task<bool> DelAllergy(int drug_allergy_id)
        {
            DrugAllergyModel FoundAllergy = await SerchAllergyId(drug_allergy_id);
            if (FoundAllergy == null)
            {
                throw new Exception("Drug Allergy not found");
            }
            _dbContext.DrugAllergy.Remove(FoundAllergy);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
