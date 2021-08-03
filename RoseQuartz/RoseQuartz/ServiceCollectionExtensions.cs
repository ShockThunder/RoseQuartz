using Microsoft.Extensions.DependencyInjection;

namespace RoseQuartz
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRoseQuartz(this IServiceCollection services)
        {
            services.AddRazorPages();
            return services;
        }
    }
}