namespace FDMC.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.DependencyInjection;
    using Models;

    public class FdmcDbContext : DbContext
    {
        public FdmcDbContext(DbContextOptions<FdmcDbContext> options) : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }

        public class FdmcDbContextContextFactory
            : IDesignTimeDbContextFactory<FdmcDbContext>
        {
            public FdmcDbContext CreateDbContext(string[] args) =>
                Program.BuildWebHost(args).Services
                    .GetRequiredService<FdmcDbContext>();
        }
    }
}