using API_consulta.Class;
using API_consulta.Managemet.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientManagement _patientManagement;
        
        public PatientController(IPatientManagement patientManagement)
        {
            _patientManagement = patientManagement;
        }
        [HttpPost]
        public async Task<ActionResult<PatientModel>> AddPatient([FromBody] PatientModel patientModel)
        {
            PatientModel patient = await _patientManagement.AddPatient(patientModel);
            return Ok(patient);
        }
        [HttpGet("patient id")]
        public async Task<ActionResult<PatientModel>> SerchPatientId(int patient_id)
        {
            PatientModel patient = await _patientManagement.SerchPatientId(patient_id);
            return Ok(patient);
        }

        [HttpPut]
        public async Task<ActionResult<PatientModel>> AttPatient([FromBody] PatientModel patientModel, int patient_id)
        {
            patientModel.PatientId = patient_id;
            PatientModel patient = await _patientManagement.AttPatient(patientModel, patient_id);
            return Ok(patient);
        }

        [HttpDelete]
        public async Task<ActionResult<PatientModel>> DelPatient(int patient_id)
        {
            bool delPatient = await _patientManagement.DelPatient(patient_id);
            return Ok(delPatient);
        }


    }
}
