using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestNet.Entidades;

namespace TestNet.Configuraciones {
    public class ContactoConfiguracion : IEntityTypeConfiguration<Contacto> {

        public void Configure (EntityTypeBuilder<Contacto> builder) { 
            
            builder.HasKey("Id");

            builder.Property(c => c.Id).HasColumnName("ContactoID");

        }

    }

}