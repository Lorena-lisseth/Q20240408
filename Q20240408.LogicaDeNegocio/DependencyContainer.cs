using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Q20240408.AccesoADatos;

namespace Q20240408.LogicaDeNegocio
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDalDependecies(configuration);
            services.AddScoped<PersonaQBL>();
            return services;
        }
    }
}