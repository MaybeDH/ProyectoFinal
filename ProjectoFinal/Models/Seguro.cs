using System.ComponentModel.DataAnnotations;

namespace ProjectoFinal.Models
{
    public class Seguro
    {
        [Key]

        public int idSeguro { get; set; }
        public string tipo { get; set; }
        public double importe { get; set; }
        public string fechaImporte { get; set; }
        public int idEmpleado { get; set; }
    }
}
