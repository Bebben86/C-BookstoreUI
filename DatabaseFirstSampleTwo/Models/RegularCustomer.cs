using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class RegularCustomer
    {
        public int? NoOfOrders { get; set; }
        public string Customer { get; set; }
        public int CustomersId { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPostbox { get; set; }
        public string CustomerZipcode { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
    }
}
