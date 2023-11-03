using Microsoft.AspNetCore.Mvc;
using ProjectoFinal.Context;
using ProjectoFinal.Models;

namespace ProjectoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TituloController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public TituloController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarTitulo")]
        public async Task<IActionResult> Post([FromBody] Titulo titulo)
        {
            _aplicacionContext.Titulo.Add(titulo);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado correctamente");
        }
        [HttpGet]
        [Route("MostrarTitulo")]
        public async Task<IActionResult> Get()
        {
            List<Titulo> listaTitulos = _aplicacionContext.Titulo.OrderByDescending(e => e.idTitulo).ToList();
            return StatusCode(StatusCodes.Status200OK, listaTitulos);
        }
        [HttpPut]
        [Route("EditarTitulo/")]
        public async Task<IActionResult> Put([FromBody] Titulo titulo)
        {
            _aplicacionContext.Titulo.Update(titulo);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente ");
        }
        [HttpDelete]
        [Route("EliminarTitulo/")]
        public async Task<IActionResult> Delete(int? id)
        {
            Titulo titulo = _aplicacionContext.Titulo.Find(id);
            _aplicacionContext.Titulo.Remove(titulo);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente  ");
        }
    }
}
