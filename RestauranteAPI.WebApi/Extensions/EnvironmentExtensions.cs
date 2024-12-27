using RestauranteAPI.Domain.Shared;
using System.Runtime.CompilerServices;

namespace RestauranteAPI.WebApi.Extensions
{
    public static class EnvironmentExtensions
    {
        public static void AddEnvironmentConfiguration(this WebApplicationBuilder builder)
        {
            RestaurateAPIEnvironment.SqlServer = Environment.GetEnvironmentVariable("SQLSERVER") ?? string.Empty;
        }
    }
}
