<<<<<<< HEAD
﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
=======
﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RestauranteAPI.Application.Interfaces;
using RestauranteAPI.Application.Services;
using RestauranteAPI.Application.Shared.Behavior;
using System.Reflection;
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d

namespace RestauranteAPI.Application
{
    public static class ServiceExtensions
    {
<<<<<<< HEAD
        public static void ConfigureApplicationApp(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddScoped<ICidadeService, CidadeService>();
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IClienteService, ClienteService>();
=======

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
>>>>>>> 624371678c4db7d24d90d4c257a8334cf0c67e7d
        }
    }
}
