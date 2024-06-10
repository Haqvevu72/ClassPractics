using CacheManager.Core;
using DatabaseProject.DbContext;
using Microsoft.Extensions.DependencyInjection;

namespace DatabaseProject;

public static class RegisterDatabase
{
    public static void AddDatabase(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<AppDbContext>(options =>
        {
            ConfigurationBuilder configurationBuilder = new();
            var builder = configurationBuilder.
        });
    }
}