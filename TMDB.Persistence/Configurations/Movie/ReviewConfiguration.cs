using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMDB.Models.Movie;

namespace TMDB.Persistence.Configurations.Movie
{
    public class ReviewConfiguration : IEntityTypeConfiguration<ReviewModel>
    {
        public void Configure(EntityTypeBuilder<ReviewModel> builder)
        {
            // Class Properties
            builder.ToTable("Reviews");
            builder.Property(e => e.Id)
                .IsRequired()
            ;
            builder.Property(e => e.Author);
            builder.Property(e => e.Content);
            builder.Property(e => e.CreatedAt);
            builder.Property(e => e.UpdatedAt);
            builder.Property(e => e.Url);
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
