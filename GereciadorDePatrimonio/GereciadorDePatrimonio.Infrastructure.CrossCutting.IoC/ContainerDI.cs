using Microsoft.Extensions.DependencyInjection;
using GereciadorDePatrimonio.ApplicationServices.Services;
using GereciadorDePatrimonio.Domain.Marcas.Interfaces;
using GereciadorDePatrimonio.Domain.Patrimonios.Interfaces;
using GereciadorDePatrimonio.Infrastructure.Data.Repository;

namespace GereciadorDePatrimonio.Infrastructure.CrossCutting.IoC
{
    public static class ContainerDI
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            // Services
            services.AddScoped<IMarcaAppService, MarcaAppService>();
            services.AddScoped<IPatrimonioAppService, PatrimonioAppService>();

            // Repositories 
            services.AddScoped<IMarcaRepository, MarcasRepository>();
            services.AddScoped<IPatrimonioRepository, PatrimonioRepository>();

        }
    }
}
