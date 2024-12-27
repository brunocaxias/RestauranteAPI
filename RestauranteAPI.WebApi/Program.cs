using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RestauranteAPI.Application;
using RestauranteAPI.Infrastructure;
using RestauranteAPI.Infrastructure.Context;
using RestauranteAPI.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddEnvironmentConfiguration();
builder.Services.AddControllers();
builder.Services.ConfigurePersistenceApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();
builder.Services.ConfigureCorsPolicy();
builder.Services.ODataConfiguration();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    options.CustomSchemaIds(type => type.ToString());
}
);

var app = builder.Build();

CreateDatabase(app);

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors();

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllers();

app.Run();

void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AppDbContext>();
    dataContext?.Database.EnsureCreated();
    //dataContext?.Database.Migrate();
}
