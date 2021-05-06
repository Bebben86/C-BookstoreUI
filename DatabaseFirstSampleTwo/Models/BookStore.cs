using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class BookStore
    {
        public BookStore()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressesId { get; set; }

        public virtual Address Addresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
