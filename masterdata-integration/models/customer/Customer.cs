using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace masterdata_integration.models.customer
{
    public class Customer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public string TaxOffice { get; set; }    
        public string TaxNumber_IdentificationNumber { get; set; }
        public int DistributorBranchId { get; set; }      
        public int WarehouseId { get; set; }
        public int TradingGroupId { get; set; }
        public int PaymentTypeId { get; set; }
        public int CustomerChannelId { get; set; }
        public int CustomerTypeId { get; set; }
        public bool IsbillCustomer { get; set; }
        public bool IsWayCustomer { get; set; }
        public int SalesmanId { get; set; }
        public bool CustomerBussinessType { get; set; }

        //public City city { get; set; }
        //public District district { get; set; }
        //public CustomerType customerType { get; set; }
        //public PaymentType paymentType { get; set; }
        //public CustomerChannel customerChannel { get; set; }

    }
}