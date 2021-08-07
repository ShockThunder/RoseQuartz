using System;
using System.IO;
using System.Reflection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace RoseQuartz
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseRoseQuartz(this IApplicationBuilder builder, RoseQuartzOptions options, Action<Services> configure = null)
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
            return builder;
        }
    }
}