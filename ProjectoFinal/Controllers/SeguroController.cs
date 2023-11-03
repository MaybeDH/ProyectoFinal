using Microsoft.AspNetCore.Mvc;
using ProjectoFinal.Context;
using ProjectoFinal.Models;

namespace ProjectoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeguroController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public SeguroController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarSeguro")]
        public async Task<IActionResult> Post([FromBody] Seguro seguro)
        {
            _aplicacionContext.Seguro.Add(seguro);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado correctamente");
        }
        [HttpGet]
        [Route("MostrarSeguro")]
        public async Task<IActionResult> Get()
        {
            List<Seguro> listaSeguros = _aplicacionContext.Seguro.OrderByDescending(e => e.idSeguro).ToList();
            return StatusCode(StatusCodes.Status200OK, listaSeguros);
        }
        [HttpPut]
        [Route("EditarSeguro/")]
        public async Task<IActionResult> Put([FromBody] Seguro seguro)
        {
            _aplicacionContext.Seguro.Update(seguro);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente ");
        }
        [HttpDelete]
        [Route("EliminarSeguro/")]
        public async Task<IActionResult> Delete(int? id)
        {
            Seguro seguro = _aplicacionContext.Seguro.Find(id);
            _aplicacionContext.Seguro.Remove(seguro);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente  ");
        }
    }
}
