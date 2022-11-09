using API_consulta.Class;
using API_consulta.Management;
using API_consulta.Management.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class SymptomsController : ControllerBase
    {
        private readonly ISymptomsManagements _symptomsManagement;

        public SymptomsController(ISymptomsManagements simptomsManagement)
        {
            _symptomsManagement = simptomsManagement;
        }
        [HttpPost]
        public async Task<ActionResult<SymptomsModel>> AddSymptoms([FromBody] SymptomsModel symptomsModel)
        {
            SymptomsModel symptoms = await _symptomsManagement.AddSymptoms(symptomsModel);
            return Ok(symptoms);
        }
        [HttpGet("symptoms id")]
        public async Task<ActionResult<SymptomsModel>> SerchSymptomsId(int symptoms_id)
        {
            SymptomsModel symptoms = await _symptomsManagement.SerchSymptomsId(symptoms_id);
            return Ok(symptoms);
        }
        [HttpGet]
        public async Task<ActionResult<List<SymptomsModel>>> GetAllSymptoms()
        {
            List<SymptomsModel> symptoms = await _symptomsManagement.GetAllSymptoms();
            return Ok(symptoms);
        }

        [HttpDelete]
        public async Task<ActionResult<SymptomsModel>> DelSymptoms(int symptoms_id)
        {
            bool delSymptoms = await _symptomsManagement.DelSymptoms(symptoms_id);
            return Ok(delSymptoms);
        }
    }
}
