using System.ComponentModel.DataAnnotations;

namespace ProjectoFinal.Models
{
    public class Departamento
    {
        [Key]

        public int idDepartamento { get; set; }
        public string nombre { get; set; }
        public string area { get; set; }
    }
}
