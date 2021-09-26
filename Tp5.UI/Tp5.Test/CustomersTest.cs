using Domain.DTO_S;
using Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tp5.AccesData.Queries;
using Tp5.AccesData.Queries.Repository;
using Tp5.Service;

namespace Tp5.Test
{
    [TestClass]
    public class CustomersTest
    {
        ICustomersQuery Query;
        ICustomerService Service;
        List<CustomerDto> Customers;
        public CustomersTest()
        {
            this.Query = new CustomersQuery();
            this.Service = new CustomerService(Query);
            this.Customers = new List<CustomerDto>();
        }
        
        [TestMethod]
        public void CustomerServiceDevuelveCustomers()
        {
           Assert.IsInstanceOfType(Service.GetCustomer() , typeof(Customers));
        }
        [TestMethod]
        public void CustomerEsDeRegionWA()
        {
            Customers = Service.GetCustomersWashinton();
            foreach (CustomerDto customer in Customers)
            {
                Assert.AreEqual("WA", customer.Region);
            }
            
        }

    }
}
