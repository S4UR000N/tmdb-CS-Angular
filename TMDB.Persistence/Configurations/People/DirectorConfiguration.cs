using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMDB.Models.Movie;
using TMDB.Models.People;

namespace TMDB.Persistence.Configurations.People
{
    public class DirectorConfiguration : IEntityTypeConfiguration<DirectorModel>
    {
        public void Configure(EntityTypeBuilder<DirectorModel> builder)
        {
            // Class Properties
            builder.ToTable("Crew");
            builder.Property(e => e.Id)
                .IsRequired()
            ;
            builder.Property(e => e.Adult);
            builder.Property(e => e.Gender);
            builder.Property(e => e.KnownForDepartment);
            builder.Property(e => e.Name);
            builder.Property(e => e.OriginalName);
            builder.Property(e => e.Popularity);
            builder.Property(e => e.ProfilePath);
            builder.Property(e => e.CreditId);
            builder.Property(e => e.Department);
            builder.Property(e => e.Job);
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
