using Microsoft.EntityFrameworkCore;
using ProductQueryMS.DbContexts;

namespace ProductQueryMS;

public static class Register
{
    public static void AddQueryDatabaseRegister(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            ConfigurationBuilder configurationBuilder = new();
            var builder = configurationBuilder.AddJsonFile("appsettings.json").Build();
            
            options.UseSqlServer(builder.GetConnectionString("default"));

        });
    }
}