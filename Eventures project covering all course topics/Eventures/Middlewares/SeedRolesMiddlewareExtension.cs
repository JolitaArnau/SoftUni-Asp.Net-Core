using Microsoft.AspNetCore.Builder;

namespace Eventures.Web.Middlewares
{
    public static class SeedRolesMiddlewareExtensions
    {
        public static IApplicationBuilder UseSeedRoles(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedRolesMiddleware>();
        }
    }
}