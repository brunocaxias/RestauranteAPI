using MediatR;
using RestauranteAPI.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.CidadeCases.Delete
{
    public record DeleteCidadeCommand(Guid Id) : IRequest<ApiResponse>;
}
