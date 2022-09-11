using System.Diagnostics.CodeAnalysis;

namespace Common.Shared.Response
{
    public class PaginatedResponseBaseModel<T>
    {
        [AllowNull]
        public T Result { get; set; }
        public long TotalResultCount { get; set; }
        public long CurrentPage { get; set; }
        public long CurrentPageSize { get; set; }
        public long TotalPages
        {
            get
            {
                if (CurrentPageSize == 0L)
                {
                    return 0L;
                }
                long num = TotalResultCount / CurrentPageSize;
                if (TotalResultCount % CurrentPageSize > 0)
                {
                    num++;
                }
                return num;
            }
        }
    }
}
