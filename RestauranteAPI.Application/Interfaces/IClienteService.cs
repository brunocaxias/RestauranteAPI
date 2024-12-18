using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.Interfaces.Common;
using RestauranteAPI.Domain.Entities;

namespace RestauranteAPI.Application.Interfaces
{
    public interface IClienteService : IBaseService<ClienteRequestDTO, ClienteResponseDTO, Cliente>
    {
    }
}
