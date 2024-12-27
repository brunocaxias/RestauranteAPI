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

namespace RestauranteAPI.Application.UseCases.CidadeCases.Update
{
    public class UpdateCidadeHandler : UpdateHandler<ICidadeService, UpdateCidadeCommand, CidadeRequestDTO, CidadeResponseDTO, Cidade>
    {
        public UpdateCidadeHandler(IUnitOfWork unitOfWork, ICidadeService service, IMapper mapper) : base(unitOfWork, service, mapper)
        {
        }
    }
}
