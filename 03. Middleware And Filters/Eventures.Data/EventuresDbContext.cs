namespace Eventures.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class EventuresDbContext : IdentityDbContext<EventuresUser>
    {
        public EventuresDbContext(DbContextOptions<EventuresDbContext> options)
            : base(options)
        {
        }

    }
    
    public class BloggingContextFactory : IDesignTimeDbContextFactory<EventuresDbContext>
    {
        public EventuresDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EventuresDbContext>();

            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=EventuresDb;User ID=SA;Password=4e6mi4ka!");

            return new EventuresDbContext(optionsBuilder.Options);
        }
    }
}