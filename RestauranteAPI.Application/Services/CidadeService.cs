using AutoMapper;
using RestauranteAPI.Application.DTOs.Request;
using RestauranteAPI.Application.DTOs.Response;
using RestauranteAPI.Application.Interfaces;
<<<<<<< HEAD
=======
using RestauranteAPI.Application.Services.Common;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
using RestauranteAPI.Domain.Entities;
using RestauranteAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.Services
{
<<<<<<< HEAD
    public class CidadeService : BaseService<
        CidadeRequestDTO,
        CidadeResponseDTO,
        Cidade,
        ICidadeRepository>, ICidadeService
    {
        public CidadeService(ICidadeRepository repository, IMapper mapper) : base(repository, mapper)
=======
    public class CidadeService :
        BaseService<CidadeRequestDTO, CidadeResponseDTO, Cidade, ICidadeRepository>,
        ICidadeService
    {
        public CidadeService(IMapper mapper, ICidadeRepository repository) : base(mapper, repository)
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
        {
        }
    }
}
