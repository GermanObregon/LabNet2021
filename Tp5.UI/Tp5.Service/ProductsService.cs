using Domain.DTO_S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.AccesData.Queries.Repository;

namespace Tp5.Service
{
    public interface IProductsService
    {
        List<ProductCategoryDto> GetProductSinStock();
        List<ProductCategoryDto> GetProductConStockYPrecioMayor3();
        ProductCategoryDto GetProductId798();
        List<ProductCategoryDto> GetAllProductOrdenadosNombre();
        List<ProductCategoryDto> GetAllProductOrdenadosPrecioUnitario();
        List<ProductCategoryDto> GetAllProduct();
        ProductCategoryDto GetFirstProduct();
       



    }
    public class ProductsService : IProductsService
    {
        private readonly IProductsQuery Query;
        public ProductsService(IProductsQuery productoQuery)
        {
            this.Query = productoQuery;
        }

        public List<ProductCategoryDto> GetAllProduct()
        {
            return Query.GetAllProducts();
        }

        public List<ProductCategoryDto> GetAllProductOrdenadosNombre()
        {
            return Query.GetAllProducts().OrderBy(P => P.NombreProducto).ToList();
        }

        public List<ProductCategoryDto> GetAllProductOrdenadosPrecioUnitario()
        {
            return Query.GetAllProducts().OrderByDescending(P => P.PrecioUnitario).ToList(); ;
        }

       

        public ProductCategoryDto GetFirstProduct()
        {
            return Query.GetFirstProduct();
        }

        public List<ProductCategoryDto> GetProductConStockYPrecioMayor3()
        {
            return Query.GetProductsWithStockUnitPrice();
        }

        public ProductCategoryDto GetProductId798()
        {
            try
            {
                return Query.GetProductId798();
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        public List<ProductCategoryDto> GetProductSinStock()
        {
            return Query.GetProductStockZero();
        }
    }
}
