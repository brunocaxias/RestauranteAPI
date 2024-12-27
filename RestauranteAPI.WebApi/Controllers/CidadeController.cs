using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.UseCases.CidadeCases.Create;
using RestauranteAPI.Application.UseCases.CidadeCases.Delete;
using RestauranteAPI.Application.UseCases.CidadeCases.GetAll;
using RestauranteAPI.Application.UseCases.CidadeCases.GetById;
using RestauranteAPI.Application.UseCases.CidadeCases.Update;
using RestauranteAPI.WebApi.Controllers.Common;

namespace RestauranteAPI.WebApi.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    public class CidadeController : BaseController
        <GetAllCidadeCommand,
        GetByIdCidadeCommand,
        CreateCidadeCommand,
        UpdateCidadeCommand,
        DeleteCidadeCommand,
        CidadeResponseDTO
        >
    {
        public CidadeController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}
