using RestauranteAPI.Domain.Enums;

namespace RestauranteAPI.Application.DTOs.Response
{
    public class PedidoResponseDTO : BaseDTO
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public ClienteResponseDTO? Cliente { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
    }
}
