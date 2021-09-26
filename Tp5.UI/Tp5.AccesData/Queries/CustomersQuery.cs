using Domain.DTO_S;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.AccesData.Queries.Repository;

namespace Tp5.AccesData.Queries
{
    public class CustomersQuery : ICustomersQuery
    {
        private readonly NorthwindContext Contexto;
        public CustomersQuery()
        {
            this.Contexto = new NorthwindContext();
        }

        public List<CustomerDto> GetCustomersWA()
        {
            return Contexto.Customers.Where(C => C.Region == "WA")
                                     .Select(customer => new CustomerDto
                                     {
                                         NombreCompania = customer.CompanyName,
                                         Region = customer.Region,
                                         NombreContacto = customer.ContactName,
                                         Pais = customer.Country,
                                         Ciudad = customer.City


                                     }).ToList();
        }

        public List<CustomerDto> GetAllCustomers()
        {
            return Contexto.Customers.Select(C => new CustomerDto
            {
                NombreCompania = C.CompanyName,
                NombreContacto = C.ContactName,
                Ciudad = C.City,
                Region = C.Region,
                Pais = C.Country
            }).ToList();
        }

        public Customers GetOneCustomer()
        {
            try
            {
                var query = Contexto.Customers.Take(1).ToList();
                Customers customer = query[0];
                return customer;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<CustomerOrdersDto> GetCustomersAndOrders()
        {
            DateTime fecha = new DateTime(1997, 1, 1);
            var query = (from C in Contexto.Customers
                         join O in Contexto.Orders
                         on C.CustomerID equals O.CustomerID
                         where C.Region == "WA" && DbFunctions.TruncateTime(O.OrderDate) > DbFunctions.TruncateTime(fecha)
                         select new CustomerOrdersDto
                         {
                             NombreCompania = C.CompanyName,
                             NombreContacto = C.ContactName,
                             Region = C.Region,
                             OrdenId = O.OrderID,
                             FechaOrden = O.OrderDate.Value
                         }
                         ).ToList();
            return query;
        }

        public List<Customers> GetAllDistinctCustomers()
        {
            return Contexto.Customers.Distinct().ToList();
        }
    }
    public class CustomersExceptionsExtension : Exception
    {
        public CustomersExceptionsExtension() : base("No se Encuentran Customers")
        {

        }
    }
       
}

