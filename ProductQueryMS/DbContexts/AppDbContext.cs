using Microsoft.EntityFrameworkCore;
using ProductQueryMS.Model;

namespace ProductQueryMS.DbContexts;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}