using Microsoft.Extensions.DependencyInjection;

namespace ClothingShopApi.Database
{
    public static class ConfigureDatabaseExtensions
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services)
        {
            services.AddDbContext<ClothingShopDbContext>();

            return services;
        }
    }
}
