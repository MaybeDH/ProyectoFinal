using System.ComponentModel.DataAnnotations;

namespace ProjectoFinal.Models
{
    public class Empleado
    {
        [Key]
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool genero { get; set; }
        public string fechaNacimiento { get; set; }
        public int idDepartamento { get; set; }
    }
}
