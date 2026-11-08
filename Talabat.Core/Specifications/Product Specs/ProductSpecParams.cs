using System;
using System.Collections.Generic;
using System.Text;

namespace Talabat.Core.Specifications.Product_Specs
{
    public class ProductSpecParams
    {
        private const int MaxPageSize = 10;
        private int pageSize = 5;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > MaxPageSize ? MaxPageSize : value; }
        }
        public int PageIndex { get; set; } = 1; 
        public string? Sort { get; set; }

        private string Search;

        public string search
        {
            get { return Search; }
            set { Search = value?.ToLower(); }
        }

        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }


    }
}
