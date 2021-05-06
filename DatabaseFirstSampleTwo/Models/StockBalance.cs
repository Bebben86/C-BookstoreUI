using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class StockBalance
    {
        public int NumberOfItems { get; set; }
        public int BookStoresId { get; set; }
        public string BooksIsbn13 { get; set; }

        public virtual BookStore BookStores { get; set; }
        public virtual Book BooksIsbn13Navigation { get; set; }
    }
}
