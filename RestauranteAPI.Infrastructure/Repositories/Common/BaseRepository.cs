using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;

namespace RestauranteAPI.Infrastructure.Repositories.Common
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public async Task<bool> Any(Guid id)
        {
<<<<<<< HEAD
            return await DbSet.AnyAsync(x =>x.Id.Equals(id));
=======
            return await DbSet.AnyAsync(x => x.Id == id);
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
        }

        public async Task Create(T entity)
        {
            await Context.AddAsync(entity);
        }

        public async Task Delete(T entity)
        {
            entity.Delete();
            await Task.Run(() => Context.Remove(entity), new CancellationToken());
        }

        public IQueryable<T> GetAll()
        {
            return DbSet
                .AsSplitQuery()
                .AsQueryable();
        }

        public IQueryable<T> GetById(Guid id)
        {
            return DbSet
                .Where(x => x.Id == id)
<<<<<<< HEAD
                .AsNoTracking()
=======
                .AsSplitQuery()
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
                .AsQueryable();
        }

        public async Task Update(T entity)
        {
            await Task.Run(() => Context.Update(entity), new CancellationToken());
        }
    }
}
