using Common.Models.Audit;

namespace TMDB.Models.Movie
{
    public class GenreModel : AuditableEntity
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<MovieModel>? Movies { get; set; }
    }
}
