using Common.Application.DbContextInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TMDB.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TmdbDbContext")));
            services.AddScoped<ITmdbDbContext>(provider =>
            {
                var dbContext = provider.GetService<TmdbDbContext>();
                return dbContext is not null ? dbContext : throw new Exception("Can not get the database service of " + nameof(TmdbDbContext));
            });

            return services;
        }
    }
}
