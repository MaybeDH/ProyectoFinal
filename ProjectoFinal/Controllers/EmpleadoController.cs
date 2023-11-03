using Microsoft.AspNetCore.Mvc;
using ProjectoFinal.Context;
using ProjectoFinal.Models;

namespace ProjectoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public EmpleadoController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarEmpleado")]
        public async Task<IActionResult> Post([FromBody] Empleado empleado)
        {
            _aplicacionContext.Empleado.Add(empleado);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado correctamente");
        }
        [HttpGet]
        [Route("MostrarEmpleado")]
        public async Task<IActionResult> Get()
        {
            List<Empleado> listaEmpleados = _aplicacionContext.Empleado.OrderByDescending(e => e.idEmpleado).ToList();
            return StatusCode(StatusCodes.Status200OK, listaEmpleados);
        }
        [HttpPut]
        [Route("EditarEmpleado/")]
        public async Task<IActionResult> Put([FromBody] Empleado empleado)
        {
            _aplicacionContext.Empleado.Update(empleado);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente ");
        }
        [HttpDelete]
        [Route("EliminarEmpleado/")]
        public async Task<IActionResult> Delete(int? id)
        {
            Empleado empleado = _aplicacionContext.Empleado.Find(id);
            _aplicacionContext.Empleado.Remove(empleado);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente  ");
        }
    }
}
