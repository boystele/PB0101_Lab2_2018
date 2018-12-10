using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGPA.ApplicationCore.Entity;


namespace SGPA.Infrastructure.EntityConfig
{
    public class MarcaConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Configurando a entidade Cliente com Fluent API
            builder.Property(x => x.Nome)
           .HasColumnType("varchar(30)");

            builder.Property(x => x.Email)
          .HasColumnType("varchar(30)");


        }
    }
}