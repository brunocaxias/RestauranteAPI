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
    public class CidadeRequestDTO : IRequest<ApiResponse>
    {
        public string? Nome { get; set; }
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
=======
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Application.DTOs.Request
{
    public class CidadeRequestDTO : BaseDTO, IRequest<TResult<CidadeResponseDTO>>
    {
        public string Nome { get; set; } = string.Empty;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
    }
}
