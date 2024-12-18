using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories.Common;

namespace RestauranteAPI.Infrastructure.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(AppDbContext context) : base(context)
        {
        }
    }
}
