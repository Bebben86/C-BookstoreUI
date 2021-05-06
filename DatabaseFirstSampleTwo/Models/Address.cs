using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class Address
    {
        public Address()
        {
            BookStores = new HashSet<BookStore>();
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Box { get; set; }
        public string Street { get; set; }
        public int PostalCodeId { get; set; }

        public virtual PostalCode PostalCode { get; set; }
        public virtual ICollection<BookStore> BookStores { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
