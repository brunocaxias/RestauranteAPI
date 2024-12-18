using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Application.DTOs;
using RestauranteAPI.Application.Interfaces.Common;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;

namespace RestauranteAPI.Application.Services.Common
{
    public class BaseService<Request, Response, Entity, Repository> : IBaseService<Request, Response, Entity>
        where Entity : BaseEntity
        where Response : BaseDTO
        where Request : BaseDTO
        where Repository : IBaseRepository<Entity>
    {
        protected readonly IMapper _mapper;
        protected readonly Repository _repository;

        public BaseService(IMapper mapper, Repository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<TResult<Response>> Create(Request request, CancellationToken cancellationToken)
        {
            var result = new TResult<Response>();
            var entity = _mapper.Map<Entity>(request);
            await _repository.Create(entity);

            var response = _mapper.Map<Response>(entity);
            result.Sucess(response);
            return result;

        }

        public async Task<TResult<Response>> Delete(Guid id, CancellationToken cancellationToken)
        {
            var result = new TResult<Response>();
            var entity = await _repository.GetById(id).FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                result.AddError($"Entidade com ID {id} não existe no banco!");
                return result;
            }

            await _repository.Delete(entity);
            return result;
        }

        public IQueryable<Response> GetAll()
        {
            return _repository.GetAll().ProjectTo<Response>(_mapper.ConfigurationProvider);
        }

        public IQueryable<Response> GetById(Guid id)
        {
            return _repository.GetById(id).ProjectTo<Response>(_mapper.ConfigurationProvider);
        }

        public async Task<TResult<Response>> Update(Request request, CancellationToken cancellationToken)
        {
            var result = new TResult<Response>();
            // entidade com as alteracoes
            var entityUpdated = _mapper.Map<Entity>(request);
            // entidade que está no banco
            var entity = await _repository.GetById(request.Id).FirstOrDefaultAsync(cancellationToken);

            if (entity is null)
            {
                result.AddError($"Entidade com ID {request.Id} não existe no banco!");
                return result;
            }

            // atualizar a entidade
            entity.Update(entityUpdated);
            await _repository.Update(entity);

            var response = _mapper.Map<Response>(entity);
            result.Sucess(response);
            return result;
        }
    }
}
