using System;

using Microsoft.AspNetCore.Builder;

namespace RoseQuartz
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseRoseQuartz(this IApplicationBuilder builder, RoseQuartzOptions options,
            Action<Services> configure = null)
        {
            options = options ?? throw new ArgumentNullException(nameof(options));
            
            var services = Services.Create(options);
            configure?.Invoke(services);

            builder.Use(async (context, next) =>
            {
                context.Items[typeof(Services)] = services;
                await next.Invoke();
            });
            
            builder.UseStaticFiles();
            builder.UseRouting();

            builder.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
        }
    }
}