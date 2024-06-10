using Microsoft.EntityFrameworkCore;
using ProductCommandMS.Model;

namespace ProductCommandMS.DbContexts;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}