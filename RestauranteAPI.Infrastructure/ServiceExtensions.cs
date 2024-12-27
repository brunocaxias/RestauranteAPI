using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
<<<<<<< HEAD
using Microsoft.Extensions.Configuration;
using RestauranteAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Domain.Shared;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Repositories.Common;
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Infrastructure.Repositories;

=======
using RestauranteAPI.Domain.Interfaces;
using RestauranteAPI.Domain.Interfaces.Common;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.Infrastructure.Repositories;
using RestauranteAPI.Infrastructure.Repositories.Common;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d

namespace RestauranteAPI.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
<<<<<<< HEAD
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(RestaurateAPIEnvironment.SqlServer, x => x.MigrationsAssembly("RestauranteAPI.Infrasctructure"));
                opt.EnableSensitiveDataLogging();

            }, ServiceLifetime.Scoped);

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
=======
            // Conexao com Banco de dados
            IServiceCollection serviceCollection = services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer("Server=sqlserver,1433;Database=RestauranteDB;User ID=sa;Password=10q20w30e40r#$;Trusted_Connection=False;TrustServerCertificate=True;", y => y.MigrationsAssembly("RestauranteAPI.Infrastructure"));
                x.EnableSensitiveDataLogging();
            }, ServiceLifetime.Scoped);
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d

            // Configuracao de Injecao de Dependencias
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
        }
    }
}
