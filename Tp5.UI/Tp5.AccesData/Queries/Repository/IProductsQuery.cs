using Domain.DTO_S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5.AccesData.Queries.Repository
{
    public interface IProductsQuery
    {
        List<ProductCategoryDto> GetProductStockZero();
        List<ProductCategoryDto> GetProductsWithStockUnitPrice();
        ProductCategoryDto GetProductId798();
        List<ProductCategoryDto> GetAllProducts();
        ProductCategoryDto GetFirstProduct();

    }
}
