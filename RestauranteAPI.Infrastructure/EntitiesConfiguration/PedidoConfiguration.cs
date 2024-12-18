using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.EstadoPedido).IsRequired();
            builder.Property(x => x.Valor).IsRequired();

        }
    }
}
