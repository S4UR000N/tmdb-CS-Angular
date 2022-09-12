using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMDB.Models.Movie;
using TMDB.Models.People;

namespace TMDB.Persistence.Configurations.People
{
    public class ActorConfiguration : IEntityTypeConfiguration<ActorModel>
    {
        public void Configure(EntityTypeBuilder<ActorModel> builder)
        {
            // Class Properties
            builder.ToTable("Cast");
            builder.Property(e => e.Id)
                .IsRequired()
            ;
            builder.Property(e => e.Adult);
            builder.Property(e => e.Gender);
            builder.Property(e => e.Id);
            builder.Property(e => e.KnownForDepartment);
            builder.Property(e => e.Name);
            builder.Property(e => e.OriginalName);
            builder.Property(e => e.Popularity);
            builder.Property(e => e.ProfilePath);
            builder.Property(e => e.CastId);
            builder.Property(e => e.Character);
            builder.Property(e => e.CreditId);
            builder.Property(e => e.Order);
            // Inherited Properties
            builder.Property(e => e.Created)
                .IsRequired()
            ;
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.Updated);
            builder.Property(e => e.UpdatedBy);
            // Relations
            builder.HasMany(e => e.Movies);
        }
    }
}
