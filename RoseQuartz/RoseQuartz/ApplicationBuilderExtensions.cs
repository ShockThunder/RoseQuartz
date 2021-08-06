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
        public static IApplicationBuilder UseRoseQuartz(this IApplicationBuilder builder)
        {
            builder.UseStaticFiles();
            builder.UseRouting();

            builder.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });
            return builder;
        }
    }
}