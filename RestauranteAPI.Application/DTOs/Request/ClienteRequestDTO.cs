using MediatR;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class ClienteRequestDTO : BaseDTO, IRequest<TResult<ClienteResponseDTO>>
    {
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
    }
}
