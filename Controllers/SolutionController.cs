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

        /// <summary>
        /// Obtener todos los inmuebles. De tener un listado de mensajes, se enviarian
        /// los mensajes segun la excepcion
        /// </summary>
        /// <returns></returns>
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

        [HttpPut]
        public async Task<ActionResult<MessageResponse<InmuebleDto>>> UpdateInmueble([FromBody] InmuebleDto inmueble)
        {
            try
            {
                var inmuebleAct = await this._solutionService.UpdateInmuebleAsync(inmueble);
                if (inmuebleAct != null)
                {
                    return Ok(MessageResponse<InmuebleDto>.success(inmuebleAct));
                }else
                {
                    return Ok(MessageResponse<string>.fail("El inmueble a actualizar no existe."));
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest(MessageResponse<String>.fail(ex.Message));
            }
        }
    }
}