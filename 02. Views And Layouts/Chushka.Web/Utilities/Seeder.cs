namespace Chushka.Web.Utilities
{
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public static class Seeder
    {
        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            var adminRoleExists = await roleManager.RoleExistsAsync("Admin");
            if (!adminRoleExists)
            {
                var adminRole = new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "0" };
                var result = await roleManager.CreateAsync(adminRole);
            }

            var userRoleExists = await roleManager.RoleExistsAsync("User");
            if (!userRoleExists)
            {
                var userRole = new IdentityRole() { Name = "User", NormalizedName = "USER", ConcurrencyStamp = "1" };
                var result = await roleManager.CreateAsync(userRole);
            }
        }
    }
}
