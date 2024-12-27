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
    public class CidadeRequestDTO : IRequest<ApiResponse>
    {
        public string? Nome { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
    }
}
