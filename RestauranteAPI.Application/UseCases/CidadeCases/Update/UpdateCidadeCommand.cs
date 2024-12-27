using MediatR;
using RestauranteAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.CidadeCases.Update
{
    public record UpdateCidadeCommand(Guid Id, string Nome) : IRequest<ApiResponse>
    {
    }
}
