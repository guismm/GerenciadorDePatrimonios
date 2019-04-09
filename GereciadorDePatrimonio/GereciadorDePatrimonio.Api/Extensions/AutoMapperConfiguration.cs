using AutoMapper;
using GereciadorDePatrimonio.ApplicationServices.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GereciadorDePatrimonio.Api.Extensions
{
    public static class AutoMapperConfiguration
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            AutoMapperConfig.Register();
        }
    }
}
