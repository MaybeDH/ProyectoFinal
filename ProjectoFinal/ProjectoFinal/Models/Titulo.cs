using System.ComponentModel.DataAnnotations;

namespace ProjectoFinal.Models
{
    public class Titulo
    {
        [Key]

        public int idTitulo { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int idEmpleado { get; set; }
    }
}
