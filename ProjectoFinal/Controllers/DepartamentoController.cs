using Microsoft.AspNetCore.Mvc;
using ProjectoFinal.Context;
using ProjectoFinal.Models;

namespace ProjectoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartamentoController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public DepartamentoController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarDepartamento")]
        public async Task<IActionResult> Post([FromBody] Departamento departamento)
        {
            _aplicacionContext.Departamento.Add(departamento);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado correctamente");
        }
        [HttpGet]
        [Route("MostrarDepartamento")]
        public async Task<IActionResult> Get()
        {
            List<Departamento> listaDepartamentos = _aplicacionContext.Departamento.OrderByDescending(e => e.idDepartamento).ToList();
            return StatusCode(StatusCodes.Status200OK, listaDepartamentos);
        }
        [HttpPut]
        [Route("EditarDepartamento/")]
        public async Task<IActionResult> Put([FromBody] Departamento departamento)
        {
            _aplicacionContext.Departamento.Update(departamento);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente ");
        }
        [HttpDelete]
        [Route("EliminarDepartamento/")]
        public async Task<IActionResult> Delete(int? id)
        {
            Departamento departamento = _aplicacionContext.Departamento.Find(id);
            _aplicacionContext.Departamento.Remove(departamento);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente  ");
        }
    }
}
