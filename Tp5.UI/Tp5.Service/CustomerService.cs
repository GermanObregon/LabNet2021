using Domain.DTO_S;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp5.AccesData.Queries.Repository;

namespace Tp5.Service
{
    public interface ICustomerService
    {
        Customers GetCustomer();
        List<CustomerDto> GetCustomersWashinton();
        List<CustomerDto> GetAllCustomers();
        List<CustomerOrdersDto> GetCustomerOrder();
        List<CustomerDto> Get3CustomersWA();
        List<Customers> GetDistintosCustomers();
    }
    public class CustomerService : ICustomerService
    {
        private readonly ICustomersQuery Query;
        public CustomerService(ICustomersQuery customersQuery)
        {
            this.Query = customersQuery;
        }
        public Customers GetCustomer()
        {
            try
            {
                return Query.GetOneCustomer();
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        public List<CustomerDto> GetCustomersWashinton()
        {
            return Query.GetCustomersWA();
        }

        public List<CustomerDto> GetAllCustomers()
        {
            return Query.GetAllCustomers(); ;
        }

        public List<CustomerOrdersDto> GetCustomerOrder()
        {
            return Query.GetCustomersAndOrders();
        }

        public List<CustomerDto> Get3CustomersWA()
        {
            return Query.GetCustomersWA().Take(3).ToList();
        }

        public List<Customers> GetDistintosCustomers()
        {
            return Query.GetAllDistinctCustomers();
        }
    }
}
