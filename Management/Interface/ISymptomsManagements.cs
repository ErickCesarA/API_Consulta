using API_consulta.Class;

namespace API_consulta.Management.Interface
{
    public interface ISymptomsManagements
    {   
        Task<SymptomsModel> SerchSymptomsName(string symptoms_name);
        Task<List<SymptomsModel>> GetAllSymptoms();
        Task<SymptomsModel> AddSymptoms(SymptomsModel Symptoms);
        Task<bool> DelSymptoms(string symptoms_name);
    }
}
