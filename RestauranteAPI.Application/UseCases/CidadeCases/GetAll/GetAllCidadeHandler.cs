using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.UseCases.BaseCase;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.CidadeCases.GetAll
{
    public class GetAllCidadeHandler : GetAllHandler<ICidadeService, GetAllCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public GetAllCidadeHandler(ICidadeService service) : base(service)
        {
        }
    }
}
