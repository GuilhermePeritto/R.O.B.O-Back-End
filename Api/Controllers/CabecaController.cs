using Application.Services;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class CabecaController : ControllerBase
    {
        private readonly ICabecaService _cabecaService;

        public CabecaController(ICabecaService cabecaService)
        {
            _cabecaService = cabecaService;
        }

        // GET: api/Cabeca
        [HttpGet("api/Cabeca")]
        public ActionResult<Cabeca> GetCabeca()
        {
            return Ok(_cabecaService.GetCabeca());
        }

        // PUT: api/Cabeca/Rotacao
        [HttpPut("api/Cabeca/Rotacao")]
        public IActionResult PutRotacao([FromBody] EnumEstadoRotacaoCabeca estado)
        {
            if (_cabecaService.UpdateRotacao(estado))
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT: api/Cabeca/Inclinacao
        [HttpPut("api/Cabeca/Inclinacao")]
        public IActionResult PutInclinacao([FromBody] EnumEstadoInclinacaoCabeca estado)
        {
            if (_cabecaService.UpdateInclinacao(estado))
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
