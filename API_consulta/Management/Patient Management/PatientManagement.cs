using API_consulta.Class;
using API_consulta.Data;
using API_consulta.Managemet.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_consulta.Management.Patient_Management
{
    public class PatientManagement : IPatientManagement
    {
        private readonly QueryDbContext _dbContext;
        public PatientManagement(QueryDbContext QueryDbContext)
        {
            _dbContext = QueryDbContext;
        }
        public async Task<PatientModel> AddPatient(PatientModel Patient)
        {
            await _dbContext.Patient.AddAsync(Patient);
            await _dbContext.SaveChangesAsync();
            return Patient;
        }
        public async Task<PatientModel> SerchPatientId(int patient_id)
        {
            return await _dbContext.Patient.FirstOrDefaultAsync(finder => finder.GetPatientId() == patient_id);
        }
     
        public async Task<PatientModel> AttPatient(PatientModel Patient, int patient_id)
        {
            PatientModel FoundPatient = await SerchPatientId(patient_id);
            if (FoundPatient == null)
            {
                throw new Exception("Patient not found");
            }
            _ = FoundPatient.GetPatientName() == Patient.GetPatientName();
            _ = FoundPatient.GetPatientAge() == Patient.GetPatientAge();
            _ = FoundPatient.GetPatientSex() == Patient.GetPatientSex();
            _ = FoundPatient.GetPregnat() == Patient.GetPregnat();
            //_ = FoundPatient.GetComorbidity() == Patient.GetComorbidity();
            //_ = FoundPatient.GetWhichComobidity() == Patient.GetWhichComobidity();
            //_ = FoundPatient.GetDrugAllergy() == Patient.GetDrugAllergy();
            //_ = FoundPatient.GetWhichDrugAllergy() == Patient.GetWhichDrugAllergy();

            _dbContext.Patient.Update(FoundPatient);
            await _dbContext.SaveChangesAsync();

            return FoundPatient;
        }

        public async Task<bool> DelPatient(int patient_id)
        {
            PatientModel FoundPatient = await SerchPatientId(patient_id);
            if (FoundPatient == null)
            {
                throw new Exception("Patient not found");
            }
            _dbContext.Patient.Remove(FoundPatient);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
