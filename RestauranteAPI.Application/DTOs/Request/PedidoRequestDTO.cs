using MediatR;
<<<<<<< HEAD
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class PedidoRequestDTO : IRequest<ApiResponse>
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid PedidoClienteId { get; set; }
        public Cliente? Cliente { get; set; }
=======
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
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
        public EstadoPedido EstadoPedido { get; set; }
    }
}
