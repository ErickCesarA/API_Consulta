using API_consulta.Class;
using API_consulta.Class.Patient;
using API_consulta.Management.Patient_Management;
using API_consulta.Managemet.Interface;
using Microsoft.AspNetCore.Http;
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
        [HttpGet]
        public async Task<ActionResult<PatientModel>> SerchPatientId(int patient_id)
        {
            PatientModel patient = await _patientManagement.SerchPatientId(patient_id);
            return Ok(patient);
        }
        [HttpPost]
        public async Task<ActionResult<PatientModel>> AddPatient([FromBody] PatientModel patientModel)
        {
            PatientModel patient = await _patientManagement.AddPatient(patientModel);
            return Ok(patient);
        }

    }
}
