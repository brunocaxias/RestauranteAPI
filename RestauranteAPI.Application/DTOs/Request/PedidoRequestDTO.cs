using MediatR;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class PedidoRequestDTO : BaseDTO, IRequest<TResult<PedidoResponseDTO>>
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid ClienteId { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
    }
}
