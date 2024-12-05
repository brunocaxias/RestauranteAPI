using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Infrastructure.EntitiesConfiguration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Telefone).IsRequired();

            builder.HasIndex(x => x.Cpf).IsUnique();

            // One to Many
            builder
                .HasOne(cliente => cliente.Cidade)
                .WithMany(cidade => cidade.Clientes)
                .HasForeignKey(cliente => cliente.ClienteCidadeId);

            // Many to One
            builder
                .HasMany(cliente => cliente.Pedidos)
                .WithOne(pedido => pedido.Cliente)
                .HasForeignKey(pedido => pedido.PedidoClienteId);



        }
    }
}
