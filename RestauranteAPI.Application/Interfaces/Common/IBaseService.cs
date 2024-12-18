using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Application.Interfaces.Common
{
    public interface IBaseService<Request, Response, Entity>
    {
        IQueryable<Response> GetAll();
        IQueryable<Response> GetById(Guid id);
        Task<TResult<Response>> Create(Request request, CancellationToken cancellationToken);
        Task<TResult<Response>> Delete(Guid id, CancellationToken cancellationToken);
        Task<TResult<Response>> Update(Request request, CancellationToken cancellationToken);
    }
}
