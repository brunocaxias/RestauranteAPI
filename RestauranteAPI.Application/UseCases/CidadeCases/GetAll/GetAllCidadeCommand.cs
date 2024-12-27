using MediatR;
using RestauranteAPI.Application.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.CidadeCases.GetAll
{
    public record GetAllCidadeCommand() : IRequest<IQueryable<CidadeResponseDTO>>
    {
    }
}
