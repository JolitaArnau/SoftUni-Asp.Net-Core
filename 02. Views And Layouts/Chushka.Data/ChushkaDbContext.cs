using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Chushka.Data
{
    using Models;

    public class ChushkaDbContext : IdentityDbContext<ChushkaUser>
    {
        public ChushkaDbContext(DbContextOptions<ChushkaDbContext> options)
            : base(options)
        {
        }


        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasKey(o => o.Id);

            builder.Entity<Order>()
                .HasOne(o => o.Client)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.ClientId);

            builder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.ProductId);

            base.OnModelCreating(builder);
        }

        public class BloggingContextFactory : IDesignTimeDbContextFactory<ChushkaDbContext>
        {
            public ChushkaDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ChushkaDbContext>();

                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=ChushkaDb;User ID=SA;Password=4e6mi4ka!");

                return new ChushkaDbContext(optionsBuilder.Options);
            }
        }
    }
}