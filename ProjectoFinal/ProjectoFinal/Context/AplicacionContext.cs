using Microsoft.EntityFrameworkCore;
using ProjectoFinal.Models;

namespace ProjectoFinal.Context
{
    public class AplicacionContext: DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
     : base(options) { }
<<<<<<< HEAD
        public DbSet<Departamento> Departamento { get; set; }
=======
        public DbSet<Titulo> Titulo { get; set; }
>>>>>>> 1a45087e0e30216c0c3057a1974f0b2b49bf78e8
    }
}
