using System;
using System.Collections.Generic;
using System.Text;
using Talabat.Core.Entites;
using Talabat.Core.Specifications.Product_Specs;

namespace Talabat.Core.Specifications
{
    public class ProductWithBrandAndTypeSpecifications : BaseSpecifications<Product>
    {
        // ** get all product  **
        //When get all product we want to include the brand and category of product 
        public ProductWithBrandAndTypeSpecifications(ProductSpecParams specParams)
            :

            base(p => 

                    (string.IsNullOrEmpty(specParams.search) ||p.Name.ToLower().Contains(specParams.search)) &&
                    (!specParams.BrandId.HasValue || p.BrandId == specParams.BrandId.Value) &&
                    (!specParams.CategoryId.HasValue || p.CategoryId == specParams.CategoryId.Value)
            )
        {

            Includes.Add(p => p.Brand);
            Includes.Add(p => p.Category);

            // 
            if (!string.IsNullOrEmpty(specParams.Sort))
            {
                switch (specParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }

            }
            else
            {
                AddOrderBy(p => p.Name);
            }

            //totalProduct = 18~ 20
            //pageSize = 5
            //page index = 3
            // applyPagination( skip, take)
            ApplyPagination((specParams.PageIndex - 1) * specParams.PageSize, specParams.PageSize);

        }


        //** Get by id specification **
        //when get product by id we want to include the brand and category of product
        public ProductWithBrandAndTypeSpecifications(int id) : base(p => p.Id == id)
        {
            Includes.Add(p => p.Brand);
            Includes.Add(p => p.Category);
        }

    }
}
