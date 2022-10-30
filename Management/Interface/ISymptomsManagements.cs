using API_consulta.Class;

namespace API_consulta.Management.Interface
{
    public interface ISymptomsManagements
    {
        Task<List<SymptomsModel>> GetAllSymptoms();
        Task<SymptomsModel> AttSymptoms(SymptomsModel Symptoms, string SymptomsName);
        Task<SymptomsModel> AddSymptoms(SymptomsModel Symptoms);
        Task<bool> DelSymptoms(string SymptomsName);
    }
}
