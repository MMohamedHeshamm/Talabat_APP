using Talbat.APIs.DTOs;

namespace Talbat.APIs.Helpers
{
    public class Pagination<T>
    {
        public Pagination(int pageIndex, int pageSize, IReadOnlyList<ProductToReturnDto> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int Count { get; set; } 

        public IReadOnlyList<T> Data { get; set; }

    }
}
