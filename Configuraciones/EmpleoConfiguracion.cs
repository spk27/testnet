using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestNet.Entidades;

namespace TestNet.Configuraciones {
    public class EmpleoConfiguracion : IEntityTypeConfiguration<Empleo> {

        public void Configure (EntityTypeBuilder<Empleo> builder) { 
            
            builder.HasKey("Id");

            builder.Property(e => e.Id).HasColumnName("EmpleoID");

            builder.Property(e => e.Cargo).HasMaxLength(255).IsRequired();
            
            builder.Property(e => e.Empresa).HasMaxLength(255);

            builder.Property(e => e.NumeroTrabajadores);

        }

    }

}