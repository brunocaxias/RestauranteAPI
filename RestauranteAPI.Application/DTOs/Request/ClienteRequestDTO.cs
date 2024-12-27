using MediatR;
<<<<<<< HEAD
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
=======
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class ClienteRequestDTO : BaseDTO, IRequest<TResult<ClienteResponseDTO>>
    {
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
    }
}
