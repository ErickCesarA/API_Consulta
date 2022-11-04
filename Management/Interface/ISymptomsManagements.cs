using API_consulta.Class;

namespace API_consulta.Management.Interface
{
    public interface ISymptomsManagements
    {   
        Task<SymptomsModel> SerchSymptomsId(int symptoms_id);
        Task<List<SymptomsModel>> GetAllSymptoms();
        Task<SymptomsModel> AddSymptoms(SymptomsModel symptoms);
        Task<bool> DelSymptoms(int symptoms_id);
    }
}
