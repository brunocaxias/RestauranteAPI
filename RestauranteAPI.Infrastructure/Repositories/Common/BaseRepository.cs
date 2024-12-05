using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Common;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Task<bool> Any(Guid id)
        {
            throw new NotImplementedException();
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
                .AsQueryable();
        }

        public IQueryable<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
