using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.DbContextInterfaces
{
    public interface ITmdbDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
