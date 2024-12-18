using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories;
using RestauranteAPI.Infrastructure.Repositories.Common;

namespace RestauranteAPI.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            // Conexao com Banco de dados
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer("Server=sqlserver,1433;Database=RestauranteDB;User ID=sa;Password=10q20w30e40r#$;Trusted_Connection=False;TrustServerCertificate=True;", y => y.MigrationsAssembly("RestauranteAPI.Infrastructure"));
                x.EnableSensitiveDataLogging();
            }, ServiceLifetime.Scoped);

            // Configuracao de Injecao de Dependencias
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
        }
    }
}
