using Domain.DTO_S;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5.AccesData.Queries.Repository
{
    public interface ICustomersQuery
    {
        Customers GetOneCustomer();
        List<CustomerDto> GetCustomersWA();
        List<CustomerDto> GetAllCustomers();
        List<CustomerOrdersDto> GetCustomersAndOrders();
        List<Customers> GetAllDistinctCustomers();

    }
}
