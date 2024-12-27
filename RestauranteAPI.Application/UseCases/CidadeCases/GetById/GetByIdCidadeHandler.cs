using AutoMapper;
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

namespace RestauranteAPI.Application.UseCases.CidadeCases.GetById
{
    public class GetByIdCidadeHandler : GetByIdHandler<ICidadeService, GetByIdCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public GetByIdCidadeHandler(ICidadeService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
