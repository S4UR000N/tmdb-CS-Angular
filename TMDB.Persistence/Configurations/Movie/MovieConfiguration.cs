using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMDB.Models.Movie;

namespace TMDB.Persistence.Configurations.Movie
{
    public class MovieConfiguration : IEntityTypeConfiguration<MovieModel>
    {
        public void Configure(EntityTypeBuilder<MovieModel> builder)
        {
            // Class Properties
            builder.ToTable("Movies");
            builder.Property(e => e.Id)
                .IsRequired()
            ;
            builder.Property(e => e.PosterPath);
            builder.Property(e => e.Overview);
            builder.Property(e => e.ReleaseDate);
            //builder.Property(e => e.GenreIds);
            builder.Navigation(e => e.GenreIds);
            //builder.Property(e => e.Genres);
            builder.Property(e => e.OriginalTitle);
            builder.Property(e => e.OriginalLanguage);
            builder.Property(e => e.Title);
            builder.Property(e => e.BackdropPath);
            builder.Property(e => e.Popularity);
            builder.Property(e => e.VoteCount);
            builder.Property(e => e.Video);
            builder.Property(e => e.VoteAverage);
            //builder.Property(e => e.Reviews);
            //builder.Property(e => e.Actors);
            //builder.Property(e => e.Directors);
            // Inherited Properties
            builder.Property(e => e.Created)
                .IsRequired()
            ;
            builder.Property(e => e.CreatedBy);
            builder.Property(e => e.Updated);
            builder.Property(e => e.UpdatedBy);
            // Relations
            builder.HasMany(e => e.Genres);
            builder.HasMany(e => e.Reviews);
            builder.HasMany(e => e.Actors);
            builder.HasMany(e => e.Directors);
        }
    }
}