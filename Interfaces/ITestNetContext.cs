using Microsoft.EntityFrameworkCore;
using TestNet.Entidades;
using System.Threading;
using System.Threading.Tasks;

namespace TestNet.Interfaces {
  public interface ITestNetDbContext {
    
    DbSet<Persona> Personas { get; set; }
    DbSet<Empleo> Empleos { get; set; }
    DbSet<Contacto> Contactos { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
  }
}