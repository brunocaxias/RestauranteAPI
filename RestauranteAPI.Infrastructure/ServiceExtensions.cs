using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using RestauranteAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Shared;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Repositories.Common;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Repositories;


namespace RestauranteAPI.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(RestaurateAPIEnvironment.SqlServer, x => x.MigrationsAssembly("RestauranteAPI.Infrasctructure"));
                opt.EnableSensitiveDataLogging();

            }, ServiceLifetime.Scoped);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();

        }
    }
}
