using MediatR;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class ClienteRequestDTO : IRequest<ApiResponse>
    {
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Cpf { get; set; }
        public Cidade? Cidade { get; set; }
        public List<Pedido> Pedidos { get; set; } = [];
    }
}
