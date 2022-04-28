using Challenge.Services.Services;
using Challenge.Services.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Services.Middleware
{
    public static class DIRServices
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            services.AddScoped<ISolutionService,SolutionService>();
            return services;
        }
    }
}