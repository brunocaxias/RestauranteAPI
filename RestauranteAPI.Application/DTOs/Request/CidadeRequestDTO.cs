using MediatR;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class CidadeRequestDTO : BaseDTO, IRequest<TResult<CidadeResponseDTO>>
    {
        public string Nome { get; set; } = string.Empty;
    }
}
