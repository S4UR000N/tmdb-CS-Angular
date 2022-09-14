using Common.Models.Audit;
using System.ComponentModel.DataAnnotations;
using TMDB.Models.People;

namespace TMDB.Models.Movie
{
    public class MovieModel : AuditableEntity
    {
        public string PosterPath { get; set; } = string.Empty;
        public bool Adult { get; set; }
        public string Overview { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public EFLongCollection GenreIds { get; set; } = new EFLongCollection();
        public ICollection<GenreModel>? Genres { get; set; }
        [Key]
        public long Id { get; set; }
        public string OriginalTitle { get; set; } = string.Empty;
        public string OriginalLanguage { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string BackdropPath { get; set; } = string.Empty;
        public float Popularity { get; set; }
        public long VoteCount { get; set; }
        public bool Video { get; set; }
        public float VoteAverage { get; set; }
        public ICollection<ReviewModel>? Reviews { get; set; }
        public ICollection<ActorModel>? Actors { get; set; }
        public ICollection<DirectorModel>? Directors { get; set; }
    }
}
