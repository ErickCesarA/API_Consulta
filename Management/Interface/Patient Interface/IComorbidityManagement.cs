using API_consulta.Class;
using API_consulta.Class.Patient;

namespace API_consulta.Management.Interface.PatientInterface
{
    public interface IComorbidityManagement
    {
        Task<ComorbidityModel> SerchComorbidityId(int comorbidity_id);
        Task<List<ComorbidityModel>> GetAllComorbidity();
        Task<ComorbidityModel> AddComorbidity(ComorbidityModel comorbidity);
        Task<bool> DelComorbidity(int comorbidity_id);
    }
}
