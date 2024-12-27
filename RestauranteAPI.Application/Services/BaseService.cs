using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Application.DTOs.Common;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.Services
{
    public class BaseService<Request, Response, Entity, Repository> : IBaseService<Request, Response, Entity>
        where Entity : BaseEntity
        where Response : BaseDTO
        where Repository : IBaseRepository<Entity>

    {

        protected readonly Repository _repository;
        protected readonly IMapper _mapper;

        public BaseService(Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApiResponse> Create(Request request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);

            List<string> errors = SaveValidation(entity);

            if (errors != null && errors.Count > 0)
            {
                return new ApiResponse(400, "Erros de validação de dominio!", errors);
            }

            await _repository.Create(entity);

            return new ApiResponse(201, entity.Id.ToString(), "Item criado com sucesso!");
        }

        public async Task<ApiResponse> Delete(Guid id, CancellationToken cancellationToken)
        {
            var entity = _repository.GetById(id).FirstOrDefault();

            if (entity == null)
            {
                return new ApiResponse(404, "Item não encontrado!");
            }

            await _repository.Delete(entity);
            return new ApiResponse(200, "Item deletado com sucesso!");
        }

        public IQueryable<Response> GetAll()
        {
            var result = _repository.GetAll().ProjectTo<Response>(_mapper.ConfigurationProvider);

            return result;
        }

        public IQueryable<Response> GetById(Guid id)
        {
            var result = _repository.GetById(id).ProjectTo<Response>(_mapper.ConfigurationProvider);
            return result;
        }

        public List<string> SaveValidation(Entity entity)
        {
            return [];
        }

        public async Task<ApiResponse> Update(Request request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Entity>(request);

            List<string> errors = SaveValidation(entity);

            if (errors != null && errors.Count > 0)
            {
                return new ApiResponse(400, "Erros de validação de dominio!", errors);
            }

            var result = await _repository.GetById(entity.Id).FirstOrDefaultAsync(cancellationToken);

            if (result == null)
            {
                return new ApiResponse(404, "O item não existe!");
            }

            result.Update(entity);

            await _repository.Update(result);

            return new ApiResponse(200, result.Id.ToString(), "Item atualizado com sucesso!");
        }
    }
}
