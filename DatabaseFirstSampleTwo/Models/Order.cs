using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public int BookStoresId { get; set; }
        public int CustomersId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual BookStore BookStores { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
