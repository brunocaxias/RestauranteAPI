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
    public class CidadeService :
        BaseService<CidadeRequestDTO, CidadeResponseDTO, Cidade, ICidadeRepository>,
        ICidadeService
    {
        public CidadeService(IMapper mapper, ICidadeRepository repository) : base(mapper, repository)
        {
        }
    }
}