using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.DTOs.Response
{
    public class PedidoResponseDTO : BaseDTO
    {
        public DateTimeOffset Data { get; set; }
        public decimal Valor { get; set; }
        public Guid PedidoClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public EstadoPedido EstadoPedido { get; set; }
    }
}
