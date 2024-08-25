namespace WebApplication1.Data
{
    using Microsoft.EntityFrameworkCore;
    using WebApplication1.Models;

    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}
