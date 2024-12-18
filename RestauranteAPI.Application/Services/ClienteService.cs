﻿using AutoMapper;
using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.Services.Common;
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.Services
{
    public class ClienteService :
        BaseService<ClienteRequestDTO, ClienteResponseDTO, Cliente, IClienteRepository>,
        IClienteService
    {
        public ClienteService(IMapper mapper, IClienteRepository repository) : base(mapper, repository)
        {
        }
    }
}
