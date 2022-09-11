using Common.Models.Audit;

namespace TMDB.Models.Movie
{
    public class MovieModel : AuditableEntity
    {
        public string PosterPath { get; set; } = string.Empty;
        public bool Adult { get; set; }
        public string Overview { get; set; } = string.Empty;
        public string ReleaseDate { get; set; } = string.Empty;
        public List<uint> GenreIds { get; set; } = new List<uint>();
        public uint Id { get; set; }
        public string OriginalTitle { get; set; } = string.Empty;
        public string OriginalLanguage { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string BackdropPath { get; set; } = string.Empty;
        public float Popularity { get; set; }
        public uint VoteCount { get; set; }
        public bool Video { get; set; }
        public float VoteAverage { get; set; }
    }
}
