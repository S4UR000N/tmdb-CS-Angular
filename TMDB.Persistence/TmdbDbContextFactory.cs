using Microsoft.EntityFrameworkCore;

namespace TMDB.Persistence
{
    public class IdentityDbContextFactory : DesignTimeDbContextFactoryBase<TmdbDbContext>
    {
        protected override TmdbDbContext CreateNewInstance(DbContextOptions<TmdbDbContext> options)
        {
            return new TmdbDbContext(options);
        }
    }
}
