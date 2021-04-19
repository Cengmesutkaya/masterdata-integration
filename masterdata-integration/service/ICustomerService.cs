
using masterdata_integration.models.customer;
using System.Collections.Generic;
namespace masterdata_integration.service
{
    public interface ICustomerService
    {
        CustomerPostResponse CreateCustomer(Customer customer);
    }
}