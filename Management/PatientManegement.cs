using API_consulta.Class;
using API_consulta.Data;
using API_consulta.Managemet.Interface;

namespace API_consulta.Management
{
    public class PatientManegement : IPatientManagement
    {
        protected readonly QueryDbContext _dbContext;
        public PatientManegement(QueryDbContext QueryDbContext)
        {
            _dbContext = QueryDbContext;
        }
        public Task<PatientModel> SerchPatientId(int id)
        {
            throw new NotImplementedException();
        }
        public Task<PatientModel> AddPatient(PatientModel Patient)
        {
            throw new NotImplementedException();
        }

        public Task<PatientModel> AttPatient(PatientModel Patient, int id)
        {
            throw new NotImplementedException();
        }

        public Task<PatientModel> DelPatient(int id)
        {
            throw new NotImplementedException();
        }

    }
}
