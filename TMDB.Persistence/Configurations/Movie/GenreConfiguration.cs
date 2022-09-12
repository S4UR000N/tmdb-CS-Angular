using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMDB.Models.Movie;

namespace TMDB.Persistence.Configurations.Movie
{
    public class GenreConfiguration : IEntityTypeConfiguration<GenreModel>
    {
        public void Configure(EntityTypeBuilder<GenreModel> builder)
        {
            // Class Properties
            builder.ToTable("Genres");
            builder.Property(e => e.Id)
                .IsRequired()
            ;
            builder.Property(e => e.Name);
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
