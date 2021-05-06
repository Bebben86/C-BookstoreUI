using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrdersOrderId { get; set; }
        public string BooksIsbn13 { get; set; }
        public int NumberOfItems { get; set; }
        public decimal? Price { get; set; }

        public virtual Book BooksIsbn13Navigation { get; set; }
        public virtual Order OrdersOrder { get; set; }
    }
}
