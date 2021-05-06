using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class PostalCode
    {
        public PostalCode()
        {
            Addresses = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode1 { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
