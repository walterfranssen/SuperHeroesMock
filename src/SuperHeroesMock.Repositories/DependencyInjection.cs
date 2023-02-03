using Microsoft.Extensions.DependencyInjection;
using MockApi.Domain.Abstract;
using MockApi.Repositories;

namespace MockApi.Repositories
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddSingleton<ISuperHeroesRepository, SuperHeroesRepository>();

            return services;
        }
    }
}
