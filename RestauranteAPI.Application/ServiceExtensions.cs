using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Application.Shared.Behavior;
using System.Reflection;

namespace RestauranteAPI.Application
{
    public static class ServiceExtensions
    {

        public static IServiceCollection CongigureApplicationApp(this IServiceCollection services)
        {
            // AutoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // Mediator
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            // Pipeline De Validacao
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            // Configuracao de Injecao de Dependencia
            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IPedidoService, PedidoService>();

            return services;
        }
    }
}
