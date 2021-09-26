using Domain.DTO_S;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.AccesData.Queries.Repository;

namespace Tp5.AccesData.Queries
{
    public class ProductsQuery : IProductsQuery
    {
        private readonly NorthwindContext Contexto;
        public ProductsQuery()
        {
            this.Contexto = new NorthwindContext();
        }

        public List<ProductCategoryDto> GetAllProducts()
        {
            var query = (from P in Contexto.Products
                         join C in Contexto.Categories
                         on P.CategoryID equals C.CategoryID
                         select new ProductCategoryDto
                         {
                             NombreProducto = P.ProductName,
                             PrecioUnitario = P.UnitPrice,
                             Categoria = C.CategoryName,
                             Stock = P.UnitsInStock
                         }).ToList();
            return query;
        }

        public ProductCategoryDto GetFirstProduct()
        {
            var query = (from P in Contexto.Products
                         join C in Contexto.Categories
                         on P.CategoryID equals C.CategoryID
                         select new ProductCategoryDto
                         {
                             NombreProducto = P.ProductName,
                             PrecioUnitario = P.UnitPrice,
                             Categoria = C.CategoryName,
                             Stock = P.UnitsInStock
                         }).First();
            return query;
        }

        public ProductCategoryDto GetProductId798()
        {
            var query = Contexto.Products.Join(Contexto.Categories,
                                         product => product.CategoryID,
                                         category => category.CategoryID,
                                         (product, category) => new ProductCategoryDto
                                         {
                                             ProductoId = product.ProductID,
                                             NombreProducto = product.ProductName,
                                             PrecioUnitario = product.UnitPrice,
                                             Stock = product.UnitsInStock,
                                             Categoria = category.CategoryName

                                         }).FirstOrDefault(P => P.ProductoId == 798);
            if (query == null)
            {
                throw new ProductsExceptionsExtension();

            }
            return query;
           
           


        }

        public List<ProductCategoryDto> GetProductStockZero()
        {
            var query = (from P in Contexto.Products
                         join C in Contexto.Categories
                         on P.CategoryID equals C.CategoryID
                         where P.UnitsInStock == 0
                         select new ProductCategoryDto
                         {
                             NombreProducto = P.ProductName,
                             PrecioUnitario = P.UnitPrice,
                             Categoria = C.CategoryName,
                             Stock = P.UnitsInStock
                         }).ToList();
            return query;
        }

        public List<ProductCategoryDto> GetProductsWithStockUnitPrice()
        {
            var query = (from P in Contexto.Products
                         join C in Contexto.Categories
                         on P.CategoryID equals C.CategoryID
                         where P.UnitsInStock > 0 && P.UnitPrice > 3
                         select new ProductCategoryDto
                         {
                             NombreProducto = P.ProductName,
                             PrecioUnitario = P.UnitPrice,
                             Categoria = C.CategoryName,
                             Stock = P.UnitsInStock
                         }).ToList();
            return query;
        }
    }
    public class ProductsExceptionsExtension : Exception
    {
        public ProductsExceptionsExtension() : base("No se Encuentran el producto")
        {

        }
    }
}
