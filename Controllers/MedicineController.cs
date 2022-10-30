using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<MedicineController>> SerchMedicine()
        {
            return Ok();
        }
    }
}
