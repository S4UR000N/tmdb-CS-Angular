using Microsoft.EntityFrameworkCore;
using TMDB.Models.Movie;
using TMDB.Models.People;

namespace Common.Application.DbContextInterfaces
{
    public interface ITmdbDbContext
    {
        DbSet<MovieModel> Movies { get; set; }
        DbSet<GenreModel> Genres { get; set; }
        DbSet<ReviewModel> Reviews { get; set; }
        DbSet<ActorModel> Actors { get; set; }
        DbSet<DirectorModel> Directors { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
