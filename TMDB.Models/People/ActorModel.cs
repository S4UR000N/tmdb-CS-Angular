using Common.Models.Audit;

namespace TMDB.Models.People
{
    public class ActorModel : AuditableEntity // "Cast" Model
    {
        public bool Adult { get; set; }
        public uint? Gender { get; set; }
        public uint Id { get; set; }
        public string KnownForDepartment { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string OriginalName { get; set; } = string.Empty;
        public float Popularity { get; set; }
        public string ProfilePath { get; set; } = string.Empty;
        public uint CastId { get; set; }
        public string Character { get; set; } = string.Empty;
        public string CreditId { get; set; } = string.Empty;
        public uint Order { get; set; }
    }
}
