using API_consulta.Class;
using API_consulta.Management.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineManagement _medicineManagement;

        public MedicineController(IMedicineManagement medicineManagement)
        {
            _medicineManagement = medicineManagement;
        }

        [HttpPost]
        public async Task<ActionResult<MedicineModel>> AddMedicine([FromBody] MedicineModel medicineModel)
        {
            MedicineModel medicine = await _medicineManagement.AddMedicine(medicineModel);
            return Ok(medicine);
        }

        [HttpGet("medicine id")]
        public async Task<ActionResult<MedicineModel>> SerchMedicineId(int medicine_id)
        {
            MedicineModel medicine = await _medicineManagement.SerchMedicineId(medicine_id);
            return Ok(medicine);
        }

        [HttpGet]
        public async Task<ActionResult<List<MedicineModel>>> GetAllMedicine()
        {
            List<MedicineModel> medicines = await _medicineManagement.GetAllMedicine();
            return Ok(medicines);
        }
  
    }
}
