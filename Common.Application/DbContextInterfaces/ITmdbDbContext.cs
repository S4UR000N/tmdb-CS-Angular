using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TMDB.Models.Movie;
using TMDB.Models.People;

namespace Common.Application.DbContextInterfaces
{
    public interface ITmdbDbContext
    {
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<GenreModel> Genres { get; set; }
        public DbSet<ReviewModel> Reviews { get; set; }
        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<DirectorModel> Directors { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DatabaseFacade Database { get; }
    }
}
