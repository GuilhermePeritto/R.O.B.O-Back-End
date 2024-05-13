using Application.Services;
using Domain.Entities;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class BracoController : ControllerBase
    {
        private readonly IBracoService _bracoService;

        public BracoController(IBracoService bracoService)
        {
            _bracoService = bracoService;
        }

        [HttpGet("api/Braco/{lado}")]
        public ActionResult<Braco> GetBraco(EnumLadoBraco lado)
        {
            var braco = _bracoService.GetBraco(lado);
            if (braco != null)
            {
                return Ok(braco);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("api/Braco/{lado}/Cotovelo")]
        public IActionResult PutCotovelo(EnumLadoBraco lado, [FromBody] EnumEstadoCotovelo estado)
        {
            if (_bracoService.UpdateCotovelo(lado, estado))
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("api/Braco/{lado}/Pulso")]
        public IActionResult PutPulso(EnumLadoBraco lado, [FromBody] EnumEstadoPulso estado)
        {
            if (_bracoService.UpdatePulso(lado, estado))
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
