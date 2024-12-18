using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();

            builder
                .HasMany(cidade => cidade.Clientes)
                .WithOne(cliente => cliente.Cidade)
                .HasForeignKey(cliente => cliente.ClienteCidadeId);
        }
    }
}
