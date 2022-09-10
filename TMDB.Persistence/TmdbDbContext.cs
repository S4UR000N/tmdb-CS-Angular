using Common.Application.DbContextInterfaces;
using Common.Models;
using Microsoft.EntityFrameworkCore;

namespace TMDB.Persistence
{
    public class TmdbDbContext : DbContext, ITmdbDbContext
    {
        public TmdbDbContext(DbContextOptions<TmdbDbContext> options) : base(options)
        {

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach(var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch(entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "TMDB";
                        break;
                    case EntityState.Modified:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = "TMDB";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TmdbDbContext).Assembly);
            modelBuilder.Model.SetMaxIdentifierLength(30);
        }
    }
}
