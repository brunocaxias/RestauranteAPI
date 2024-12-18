using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.Interfaces.Common;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces
{
    public interface ICidadeService : IBaseService<CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
    }
}
