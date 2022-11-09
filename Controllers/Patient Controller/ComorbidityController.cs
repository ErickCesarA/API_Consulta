using API_consulta.Class;
using API_consulta.Class.Patient;
using API_consulta.Management.Interface.PatientInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API_consulta.Controllers.Patient_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComorbidityController : ControllerBase
    {
        private readonly IComorbidityManagement _comorbidityManagement;

        public ComorbidityController(IComorbidityManagement comorbidityManagement)
        {
            _comorbidityManagement = comorbidityManagement;
        }

        [HttpPost]
        public async Task<ActionResult<ComorbidityModel>> AddComorbidity([FromBody] ComorbidityModel comorbidityModel)
        {
            ComorbidityModel comorbidity = await _comorbidityManagement.AddComorbidity(comorbidityModel);
            return Ok(comorbidity);
        }

        [HttpGet("comorbidity id")]
        public async Task<ActionResult<ComorbidityModel>> SerchComorbidityId(int comorbidity_id)
        {
            ComorbidityModel comorbidity = await _comorbidityManagement.SerchComorbidityId(comorbidity_id);
            return Ok(comorbidity);
        }

        [HttpGet]
        public async Task<ActionResult<List<ComorbidityModel>>> GetAllComorbidity()
        {
            List<ComorbidityModel> comorbidities = await _comorbidityManagement.GetAllComorbidity();
            return Ok(comorbidities);
        }
        [HttpDelete]
        public async Task<ActionResult<ComorbidityModel>> DelComorbidity(int comorbidity_id)
        {
            bool delComorbidity = await _comorbidityManagement.DelComorbidity(comorbidity_id);
            return Ok(delComorbidity);
        }

    }
}
