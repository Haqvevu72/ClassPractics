using Microsoft.EntityFrameworkCore;
using ProductCommandMS.DbContexts;

namespace ProductCommandMS;

public static class Register
{
    public static void AddCommandDatabaseRegister(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            ConfigurationBuilder configurationBuilder = new();
            var builder = configurationBuilder.AddJsonFile("appsettings.json").Build();
            
            options.UseSqlServer(builder.GetConnectionString("default"));

        });
    }
}