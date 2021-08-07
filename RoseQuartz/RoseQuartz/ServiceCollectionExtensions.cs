using Microsoft.Extensions.DependencyInjection;

namespace RoseQuartz
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRoseQuartz(this IServiceCollection services)
        {
            services.AddScoped<SchedulerService>();
            services.AddRazorPages();
            services.ConfigureOptions(typeof(UiConfigureOptions));
            return services;
        }
    }
}