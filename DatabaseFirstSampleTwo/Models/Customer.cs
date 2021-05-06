using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string CFirstName { get; set; }
        public string CLastName { get; set; }
        public int AddressesId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Address Addresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
