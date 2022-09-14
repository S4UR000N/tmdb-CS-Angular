using Common.Models.Audit;
using System.ComponentModel.DataAnnotations;

namespace TMDB.Models.Movie
{
    public class GenreModel : AuditableEntity
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<MovieModel>? Movies { get; set; }
    }
}
