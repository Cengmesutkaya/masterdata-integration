using masterdata_integration.models.customer;
using System;
using System.Collections.Generic;
using System.Linq;
namespace masterdata_integration.service
{
    public class CustomerService : ICustomerService
    {
        public CustomerPostResponse CreateCustomer(Customer customer)
        {
            CustomerPostResponse response = new CustomerPostResponse();
            Customer createdCustomer = new Customer();
           /// List<Customer> updatedCustomers = new List<Customer>(); List için yazılacak kod
            List<Error> errors = new List<Error>();
            return response;
        }
    }
}