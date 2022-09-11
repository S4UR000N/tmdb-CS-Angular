using Common.Models.Audit;

namespace TMDB.Models.Movie
{
    public class GenreModel : AuditableEntity
    {
        public uint Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
