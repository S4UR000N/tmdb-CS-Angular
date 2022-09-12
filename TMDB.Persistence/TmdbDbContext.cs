using Common.Application.DbContextInterfaces;
using Common.Models.Audit;
using Microsoft.EntityFrameworkCore;
using TMDB.Models.Movie;
using TMDB.Models.People;

namespace TMDB.Persistence
{
    public class TmdbDbContext : DbContext, ITmdbDbContext
    {
        public DbSet<MovieModel>? Movies { get; set; }
        public DbSet<GenreModel>? Genres { get; set; }
        public DbSet<ReviewModel>? Reviews { get; set; }
        public DbSet<ActorModel>? Actors { get; set; }
        public DbSet<DirectorModel>? Directors { get; set; }

//#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TmdbDbContext(DbContextOptions<TmdbDbContext> options) : base(options) { }
//#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
