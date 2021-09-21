
using System.Collections.Generic;
using System.Linq;

using Tp4.AccesData.Queries.Repository;
using Tp4.Domain.DTO_S;

namespace Tp4.AccesData.Queries
{
    public class NombreClienteOrdenProducto : INombreClienteOrdenProducto
    {
        private readonly NorthwindContext Contexto;

        public NombreClienteOrdenProducto()
        {
            this.Contexto = new NorthwindContext();
        }
        public List<NombreClienteOrdenProductoDto> GetClientOrderProducts()
        {
            using (Contexto)
            {
                var query = (from C in Contexto.Customers
                             join O in Contexto.Orders
                             on C.CustomerID equals O.CustomerID
                             join OD in Contexto.Order_Details
                             on O.OrderID equals OD.OrderID
                             join P in Contexto.Products
                             on OD.ProductID equals P.ProductID
                             orderby O.OrderID
                             select new NombreClienteOrdenProductoDto
                             {
                                 NombreCliente = C.CompanyName,
                                 IdOrden = O.OrderID,
                                 PrecioUnitario = OD.UnitPrice,
                                 NombreProducto = P.ProductName

                             }).ToList();
                return query;
            }
        }
    }
}
