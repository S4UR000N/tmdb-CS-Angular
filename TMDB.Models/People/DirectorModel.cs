using Common.Models.Audit;
using System.ComponentModel.DataAnnotations;
using TMDB.Models.Movie;

namespace TMDB.Models.People
{
    public class DirectorModel : AuditableEntity
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
        public string CreditId { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public ICollection<MovieModel>? Movies { get; set; }
    }
}
