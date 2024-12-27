using RestauranteAPI.Domain.Common;

namespace RestauranteAPI.Domain.Interfaces.Common
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetById(Guid id);
        Task<bool> Any(Guid id);
    }
}

