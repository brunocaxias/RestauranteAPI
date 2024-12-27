using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.Interfaces
{
    public interface IPedidoService : IBaseService<PedidoRequestDTO, PedidoResponseDTO, Pedido>
    {
    }
}
