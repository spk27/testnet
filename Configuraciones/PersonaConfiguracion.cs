using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestNet.Entidades;

namespace TestNet.Configuraciones {
    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona> {

        public void Configure (EntityTypeBuilder<Persona> builder) { 
            
            builder.HasKey("Id");

            builder.Property(p => p.Id).HasColumnName("PersonaID");

            builder.Property(p => p.Nombre).HasMaxLength(255).IsRequired();

            builder.Property(p => p.Apellido).HasMaxLength(150);

            builder.Property(p => p.Cedula).HasMaxLength(15).IsRequired();

            builder.Property(p => p.Direccion).HasMaxLength(1000);

            builder.Property(p => p.EmpleoId).HasColumnName("EmpleoID");

            builder.HasOne(p => p.Empleo)
                .WithMany(e => e.Personas)
                .HasForeignKey(p => p.EmpleoId)
                .HasConstraintName("FK_Personas_Empleo");
        }

    }

}