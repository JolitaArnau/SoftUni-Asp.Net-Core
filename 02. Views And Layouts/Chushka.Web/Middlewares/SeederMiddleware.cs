namespace Chushka.Web.Middlewares
{
    using System.Threading.Tasks;
    using Utilities;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    
    public class SeederMiddleware
    {
        private readonly RequestDelegate next;

        public SeederMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext httpContext, RoleManager<IdentityRole> roleManager)
        {
            Seeder.SeedRoles(roleManager).Wait();

            return next(httpContext);
        }
    }
}
