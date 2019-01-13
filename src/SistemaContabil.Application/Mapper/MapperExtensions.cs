using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace SistemaContabil.Application.Mapper
{
    public static class MapperExtensions
    {
        public static void AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}
