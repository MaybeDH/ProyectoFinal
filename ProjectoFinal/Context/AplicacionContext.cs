using Microsoft.EntityFrameworkCore;
using ProjectoFinal.Models;

namespace ProjectoFinal.Context
{
    public class AplicacionContext: DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
     : base(options) { }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Salario> Salario { get; set; }
        public DbSet<Seguro> Seguro { get; set; }
        public DbSet<Titulo> Titulo { get; set; }
    }
}
