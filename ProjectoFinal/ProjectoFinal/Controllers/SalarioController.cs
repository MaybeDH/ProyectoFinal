using Microsoft.AspNetCore.Mvc;
using ProjectoFinal.Context;
using ProjectoFinal.Models;

namespace ProjectoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalarioController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public SalarioController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarSalario")]
        public async Task<IActionResult> Post([FromBody] Salario salario)
        {
            _aplicacionContext.Salario.Add(salario);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado correctamente");
        }
        [HttpGet]
        [Route("MostrarSalario")]
        public async Task<IActionResult> Get()
        {
            List<Salario> listaSalarios = _aplicacionContext.Salario.OrderByDescending(e => e.idSalario).ToList();
            return StatusCode(StatusCodes.Status200OK, listaSalarios);
        }
        [HttpPut]
        [Route("EditarSalario/")]
        public async Task<IActionResult> Put([FromBody] Salario salario)
        {
            _aplicacionContext.Salario.Update(salario);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente ");
        }
        [HttpDelete]
        [Route("EliminarSalario/")]
        public async Task<IActionResult> Delete(int? id)
        {
            Salario salario = _aplicacionContext.Salario.Find(id);
            _aplicacionContext.Salario.Remove(salario);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente  ");
        }
    }
}
