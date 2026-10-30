using System;
using System.Collections.Generic;
using System.Text;
using Talabat.Core.Entites;

namespace Talabat.Core.Specifications
{
    public class ProductWithBrandAndTypeSpecifications : BaseSpecifications<Product>
    {
        // ** get all product  **
        //When get all product we want to include the brand and category of product 
        public ProductWithBrandAndTypeSpecifications(string sort, int? brandId, int? categoryId)
            :

            base(p => (!brandId.HasValue || p.BrandId == brandId.Value) &&
                    (!categoryId.HasValue || p.CategoryId == categoryId.Value)
            )
        {

            Includes.Add(p => p.Brand);
            Includes.Add(p => p.Category);

            // 
            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
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
