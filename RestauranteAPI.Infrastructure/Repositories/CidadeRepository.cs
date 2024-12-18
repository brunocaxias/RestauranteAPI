using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories.Common;

namespace RestauranteAPI.Infrastructure.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
    {
        public CidadeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
