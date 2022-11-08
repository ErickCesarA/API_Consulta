using API_consulta.Class.Patient;
using API_consulta.Data;
using API_consulta.Management.Interface.PatientInterface;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace API_consulta.Management.Patient_Management
{
    public class ComorbidityManagement : IComorbidityManagement
    {
        private readonly QueryDbContext _dbContext;
        public ComorbidityManagement(QueryDbContext QueryDbContext)
        {
            _dbContext = QueryDbContext;
        }
        public async Task<ComorbidityModel> AddComorbidity(ComorbidityModel comorbidity)
        {
            await _dbContext.Comorbidity.AddAsync(comorbidity);
            await _dbContext.SaveChangesAsync();
            return comorbidity;
        }
        public async Task<ComorbidityModel> SerchComorbidityId(int comorbidity_id)
        {
            return await _dbContext.Comorbidity.FirstOrDefaultAsync(finder => finder.GetComorbidityId() == comorbidity_id);
        }
        public async Task<List<ComorbidityModel>> GetAllComorbidity()
        {
            return await _dbContext.Comorbidity.ToListAsync();
        }

        public async Task<bool> DelComorbidity(int comorbidity_id)
        {
            ComorbidityModel FoundComorbidity = await SerchComorbidityId(comorbidity_id);
            if (FoundComorbidity == null)
            {
                throw new Exception("Comorbidity not found");
            }
            _dbContext.Comorbidity.Remove(FoundComorbidity);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        
    }
}
