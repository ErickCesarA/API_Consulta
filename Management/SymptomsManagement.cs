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
        public async Task<SymptomsModel> SerchSymptomsName(string symptoms_name)
        {
            return await _dbContext.Symptoms.FirstOrDefaultAsync(finder => finder.GetSymptomsName() == symptoms_name);
        }
        public async Task<List<SymptomsModel>> GetAllSymptoms()
        {
            return await _dbContext.Symptoms.ToListAsync();
        }
        public async Task<SymptomsModel> AddSymptoms(SymptomsModel Symptoms)
        {
           _dbContext.Symptoms.Add(Symptoms);
            _dbContext.SaveChanges();
             return  Symptoms;
        }

        public async Task<bool> DelSymptoms(string symptoms_name)
        {
            SymptomsModel FoundSymptoms = await SerchSymptomsName(symptoms_name);
            if (FoundSymptoms == null)
            {
                throw new Exception("Symptoms not found");
            }
            _dbContext.Symptoms.Remove(FoundSymptoms);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
