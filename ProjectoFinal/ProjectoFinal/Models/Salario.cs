using System.ComponentModel.DataAnnotations;

namespace ProjectoFinal.Models
{
    public class Salario
    {
        [Key]

        public int idSalario { get; set; }
        public string salario { get; set; }
        public string fechaNacimiento { get; set; }
        public int idEmpleado { get; set; }
    }
}
