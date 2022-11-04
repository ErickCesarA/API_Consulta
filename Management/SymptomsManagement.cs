using API_consulta.Class;
using API_consulta.Data;
using API_consulta.Management.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_consulta.Management
{
    public class SymptomsManagement : ISymptomsManagements
    {
        private readonly QueryDbContext _dbContext;
        public SymptomsManagement(QueryDbContext QueryDbContext)
        {
            _dbContext = QueryDbContext;
        }
        public async Task<SymptomsModel> SerchSymptomsId(int symptoms_id)
        {
            return await _dbContext.Symptoms.FirstOrDefaultAsync(finder => finder.GetSymptomsId() == symptoms_id);
        }
        public async Task<List<SymptomsModel>> GetAllSymptoms()
        {
            return await _dbContext.Symptoms.ToListAsync();
        }
        public async Task<SymptomsModel> AddSymptoms(SymptomsModel symptoms)
        {
           await _dbContext.Symptoms.AddAsync(symptoms);
            await _dbContext.SaveChangesAsync();
             return  symptoms;
        }

        public async Task<bool> DelSymptoms(int symptoms_id)
        {
            SymptomsModel FoundSymptoms = await SerchSymptomsId(symptoms_id);
            if (FoundSymptoms == null)
            {
                throw new Exception("Symptoms not found");
            }
            _dbContext.Symptoms.Remove(FoundSymptoms);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
