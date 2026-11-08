using System;
using System.Collections.Generic;
using System.Text;
using Talabat.Core.Entites;

namespace Talabat.Core.Specifications.Product_Specs
{
    public class ProdusctsWIthFilterationorCountSpecification : BaseSpecifications<Product>
    {
        public ProdusctsWIthFilterationorCountSpecification(ProductSpecParams specParams)
            : base(p =>

             (string.IsNullOrEmpty(specParams.search) || p.Name.ToLower().Contains(specParams.search)) &&
             (!specParams.BrandId.HasValue || p.BrandId == specParams.BrandId.Value) &&
             (!specParams.CategoryId.HasValue || p.CategoryId == specParams.CategoryId.Value))
        {

        }
    }
}
