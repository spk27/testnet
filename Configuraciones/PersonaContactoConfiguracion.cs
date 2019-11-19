using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestNet.Entidades;

namespace TestNet.Configuraciones {
    public class PersonaContactoConfiguracion : IEntityTypeConfiguration<PersonaContacto> {

        public void Configure (EntityTypeBuilder<PersonaContacto> builder) { 
            
            builder.HasKey(pc => new { pc.PersonaId, pc.ContactoId });

            builder.Property(pc => pc.PersonaId).HasColumnName("PersonaID");

            builder.Property(pc => pc.ContactoId).HasColumnName("ContactoID");

            builder.HasOne(p => p.Persona)
                .WithMany(c => c.PersonaContactos)
                .HasForeignKey(p => p.PersonaId)
                .HasConstraintName("FK_Persona_Contactos");
            
            builder.HasOne(c => c.Contacto)
                .WithMany(p => p.PersonaContactos)
                .HasForeignKey(c => c.ContactoId)
                .HasConstraintName("FK_Contacto_Personas");

        }

    }

}