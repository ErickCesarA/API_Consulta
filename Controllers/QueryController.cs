using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_consulta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<QueryController>> SerchMedicine()
        {
            return Ok();
        }
    }
}
