using Domain.DTO_S;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tp5.AccesData.Queries;
using Tp5.AccesData.Queries.Repository;
using Tp5.Service;

namespace Tp5.Test
{
   
    [TestClass]
    public class ProductsTest
    {
        IProductsQuery Query;
        IProductsService Service;
        List<ProductCategoryDto> Productos;
        public ProductsTest()
        {
            this.Query = new ProductsQuery();
            this.Service = new ProductsService(Query);
            this.Productos = new List<ProductCategoryDto>();
        }
              

        [TestMethod]
        public void VerificarStockCeroEnProductos()
        {
           

            Productos = Service.GetProductSinStock();

            foreach (ProductCategoryDto producto in Productos)
            {
                Assert.AreEqual(Convert.ToInt16(0), producto.Stock);
            }
        }
        [TestMethod]
        public void VerificarHayStock()
        {
            Productos = Service.GetProductConStockYPrecioMayor3();
            foreach (ProductCategoryDto producto in Productos)
            {
                Assert.AreNotEqual(Convert.ToInt16(0),producto.Stock);
            }
        }
        [TestMethod]
        public void VerificarPrecioMayor3()
        {
            Productos = Service.GetProductConStockYPrecioMayor3();
            foreach (ProductCategoryDto producto in Productos)
            {
                Assert.IsTrue(producto.PrecioUnitario > 3);
            }
        }
    }
}
