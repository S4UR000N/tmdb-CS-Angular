using Common.Models.Audit;
using System.ComponentModel.DataAnnotations;
using TMDB.Models.Movie;

namespace TMDB.Models.People
{
    public class ActorModel : AuditableEntity // "Cast" Model
    {
        public bool Adult { get; set; }
        public long? Gender { get; set; }
        [Key]
        public long Id { get; set; }
        public string KnownForDepartment { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string OriginalName { get; set; } = string.Empty;
        public float Popularity { get; set; }
        public string ProfilePath { get; set; } = string.Empty;
        public long CastId { get; set; }
        public string Character { get; set; } = string.Empty;
        public string CreditId { get; set; } = string.Empty;
        public long Order { get; set; }
        public ICollection<MovieModel> Movies { get; set; }
    }
}
