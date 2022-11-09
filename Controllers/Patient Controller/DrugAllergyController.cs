using API_consulta.Class;
using API_consulta.Class.Patient;
using API_consulta.Management.Interface.PatientInterface;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers.Patient_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugAllergyController : ControllerBase
    {
        private readonly IDrugAllergyManagement _allergyManagement;

        public DrugAllergyController(IDrugAllergyManagement allergyManagement)
        {
            _allergyManagement = allergyManagement;
        }

        [HttpPost]
        public async Task<ActionResult<DrugAllergyModel>> AddAllergy([FromBody] DrugAllergyModel drugAllergyModel)
        {
            DrugAllergyModel drugAllergy = await _allergyManagement.AddAllergy(drugAllergyModel);
            return Ok(drugAllergy);
        }

        [HttpGet("drug alergy id")]
        public async Task<ActionResult<DrugAllergyModel>> SerchAllergyId(int drug_allergy_id)
        {
            DrugAllergyModel drugAllergy = await _allergyManagement.SerchAllergyId(drug_allergy_id);
            return Ok(drugAllergy);
        }

        [HttpGet]
        public async Task<ActionResult<List<DrugAllergyModel>>> GetAllAllergy()
        {
            List<DrugAllergyModel> drugAllerges = await _allergyManagement.GetAllAllergy();
            return Ok(drugAllerges);
        }

        [HttpDelete]
        public async Task<ActionResult<DrugAllergyModel>> DelAllergy(int drug_allergy_id)
        {
            bool delAllergy = await _allergyManagement.DelAllergy(drug_allergy_id);
            return Ok(delAllergy);
        }

    }
}
