using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SolutionController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<MessageResponse<String>>> GetInmuebles([FromQuery] String agencyId)
        {
            try
            {
                return Ok(MessageResponse<String>.success("Soy Mario e agencyId: " + agencyId));
            }
            catch (System.Exception ex)
            {
                return BadRequest(MessageResponse<String>.fail(ex.Message));
            }
        }
    }
}