using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Http.Models
{
    public class TmdbPaginatedResponseModel<T> where T : class, new()
    {
        public long Page { get; set; }
        public T Results { get; set; } = new T();
        public long TotalPages { get; set; }
        public long TotalResults { get; set; }
    }
}
