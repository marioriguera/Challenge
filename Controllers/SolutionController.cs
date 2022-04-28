using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Challenge.Services.DTOs;
using Challenge.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SolutionController : Controller
    {
        private readonly ISolutionService _solutionService;

        public SolutionController(ISolutionService solutionService)
        {
            _solutionService = solutionService;
        }

        [HttpGet]
        public async Task<ActionResult<MessageResponse<List<InmuebleDto>>>> GetInmuebles()
        {
            try
            {
                var inmuebles = await this._solutionService.GetInmueblesAsync();
                return Ok(MessageResponse<List<InmuebleDto>>.success(inmuebles));
            }
            catch (System.Exception ex)
            {
                return BadRequest(MessageResponse<String>.fail(ex.Message));
            }
        }
    }
}