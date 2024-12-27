﻿using AutoMapper;
using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.Mappers
{
    public class PedidoMapper : Profile
    {
        public PedidoMapper() 
        {
            CreateMap<Pedido, PedidoRequestDTO>().ReverseMap();
            CreateMap<Pedido, PedidoResponseDTO>().ReverseMap();
        }
    }
}
