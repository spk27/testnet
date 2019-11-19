using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestNet.Entidades;
using TestNet.Interfaces;

namespace TestNet.Conexto {
    public class TestNetContext : DbContext, ITestNetDbContext
    {
        public TestNetContext(DbContextOptions<TestNetContext> options) : base(options)
        { }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleo> Empleos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestNetContext).Assembly);
        }
    }
} 