using Microsoft.EntityFrameworkCore;

namespace TMDB.Persistence
{
    public class TmdbDbContextFactory : DesignTimeDbContextFactoryBase<TmdbDbContext>
    {
        protected override TmdbDbContext CreateNewInstance(DbContextOptions<TmdbDbContext> options)
        {
            return new TmdbDbContext(options);
        }
    }
}
