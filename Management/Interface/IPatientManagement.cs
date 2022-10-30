using API_consulta.Class;

namespace API_consulta.Managemet.Interface
{
    public interface IPatientManagement
    {
        Task<PatientModel> SerchPatientId(int id);
        Task<PatientModel> AddPatient(PatientModel Patient);
        Task<PatientModel> AttPatient(PatientModel Patient, int id);
        Task<PatientModel> DelPatient(int id);
    }
}
