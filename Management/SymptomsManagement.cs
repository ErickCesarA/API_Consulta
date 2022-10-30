using API_consulta.Class;
using API_consulta.Management.Interface;

namespace API_consulta.Management
{
    public class SymptomsManagement : ISymptomsManagements
    {

        public Task<List<SymptomsModel>> GetAllSymptoms()
        {
            throw new NotImplementedException();
        }
        public Task<SymptomsModel> AddSymptoms(SymptomsModel Symptoms)
        {
            throw new NotImplementedException();
        }

        public Task<SymptomsModel> AttSymptoms(SymptomsModel Symptoms, string SymptomsName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DelSymptoms(string SymptomsName)
        {
            throw new NotImplementedException();
        }
    }
}
