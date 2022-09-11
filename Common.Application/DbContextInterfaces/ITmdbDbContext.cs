namespace Common.Application.DbContextInterfaces
{
    public interface ITmdbDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
