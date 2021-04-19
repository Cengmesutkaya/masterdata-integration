using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace masterdata_integration.models.customer
{
    public class CustomerPostResponse
    {
        public List<Customer> customers { get; set; }
        public Customer customer { get; set; }
    }
}