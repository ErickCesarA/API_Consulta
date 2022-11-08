using API_consulta.Class.Patient;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API_consulta.Management.Interface.PatientInterface
{
    public interface IComorbidityManagement 
    {
        Task<ComorbidityModel> AddComorbidity(ComorbidityModel comorbidity);
        Task<ComorbidityModel> SerchComorbidityId(int comorbidity_id);
        Task<List<ComorbidityModel>> GetAllComorbidity();
        Task<bool> DelComorbidity(int comorbidity_id);
    }
}
