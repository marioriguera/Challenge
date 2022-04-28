using Challenge.Repositories.Repositories;
using Challenge.Repositories.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Repositories.Middleware
{
    public static class DIRRepositories
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            services.AddScoped<ISolutionRepository, SolutionRepository>();
            return services;
        }
    }
}