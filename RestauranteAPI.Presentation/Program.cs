

using Microsoft.EntityFrameworkCore;
using RestauranteAPI.Infrastructure;
using RestauranteAPI.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuracao da Application (Camada de Aplication)
builder.Services.ConfigurePersistenceApp(builder.Configuration);

// Configuracao do Banco (Camada de Infra)
builder.Services.ConfigurePersistenceApp(builder.Configuration);


var app = builder.Build();

CreateDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
    //dataContext?.Database.Migrate();
}