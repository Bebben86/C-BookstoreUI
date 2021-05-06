using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class Book
    {
        public Book()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Isbn13 { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public decimal? Price { get; set; }
        public DateTime Published { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
