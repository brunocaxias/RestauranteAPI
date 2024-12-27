using AutoMapper;
using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.UseCases.BaseCase;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.CidadeCases.Create
{
    public class CreateCidadeHandler : CreateHandler<ICidadeService, CreateCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public CreateCidadeHandler(IUnitOfWork unitOfWork, ICidadeService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}
