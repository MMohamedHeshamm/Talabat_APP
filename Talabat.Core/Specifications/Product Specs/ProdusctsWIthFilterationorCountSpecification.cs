using System;
using System.Collections.Generic;
using System.Text;
using Talabat.Core.Entites;

namespace Talabat.Core.Specifications.Product_Specs
{
    internal class ProdusctsWIthFilterationorCountSpecification : BaseSpecifications<Product>
    {
        public ProdusctsWIthFilterationorCountSpecification(ProductSpecParams specParams)
            : base(p => (!specParams.BrandId.HasValue || p.BrandId == specParams.BrandId.Value) &&
                    (!specParams.CategoryId.HasValue || p.CategoryId == specParams.CategoryId.Value))
        {

        }
    }
}
