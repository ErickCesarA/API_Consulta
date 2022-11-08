using API_consulta.Class;

namespace API_consulta.Managemet.Interface
{
    public interface IPatientManagement
    {
        Task<PatientModel> AddPatient(PatientModel Patient);
        Task<PatientModel> SerchPatientId(int patient_id);
        Task<PatientModel> AttPatient(PatientModel Patient, int patient_id);
        Task<bool> DelPatient(int patient_id);
    }
}
