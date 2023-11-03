using Microsoft.EntityFrameworkCore;
using ProjectoFinal.Models;

namespace ProjectoFinal.Context
{
    public class AplicacionContext: DbContext
    {
        public AplicacionContext(DbContextOptions<AplicacionContext> options)
     : base(options) { }
        public DbSet<Titulo> Titulo { get; set; }
    }
}
