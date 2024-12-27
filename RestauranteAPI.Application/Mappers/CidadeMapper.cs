using AutoMapper;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.UseCases.CidadeCases.Create;
using RestauranteAPI.Application.UseCases.CidadeCases.Delete;
using RestauranteAPI.Application.UseCases.CidadeCases.GetAll;
using RestauranteAPI.Application.UseCases.CidadeCases.GetById;
using RestauranteAPI.Application.UseCases.CidadeCases.Update;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.Mappers
{
    public class CidadeMapper : Profile
    {
        protected CidadeMapper()
        {
            CreateMap<Cidade, CidadeRequestDTO>().ReverseMap();
            CreateMap<Cidade, CidadeResponseDTO>().ReverseMap();


            CreateMap<CreateCidadeCommand, CidadeRequestDTO>().ReverseMap();
            CreateMap<UpdateCidadeCommand, CidadeRequestDTO>().ReverseMap();
            CreateMap<DeleteCidadeCommand, CidadeRequestDTO>().ReverseMap();
            CreateMap<GetAllCidadeCommand, CidadeRequestDTO>().ReverseMap();
            CreateMap<GetByIdCidadeCommand, CidadeRequestDTO>().ReverseMap();


            CreateMap<CreateCidadeCommand, Cidade>().ReverseMap();
            CreateMap<UpdateCidadeCommand, Cidade>().ReverseMap();
            CreateMap<DeleteCidadeCommand, Cidade>().ReverseMap();
            CreateMap<GetAllCidadeCommand, Cidade>().ReverseMap();
            CreateMap<GetByIdCidadeCommand, Cidade>().ReverseMap();

            CreateMap<CreateCidadeCommand, ApiResponse>().ReverseMap();
            CreateMap<UpdateCidadeCommand, ApiResponse>().ReverseMap();
            CreateMap<DeleteCidadeCommand, ApiResponse>().ReverseMap();
            CreateMap<GetAllCidadeCommand, ApiResponse>().ReverseMap();
            CreateMap<GetByIdCidadeCommand, ApiResponse>().ReverseMap();
        }
    }
}
