using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class StockBalance
    {
        public int BookStoresId { get; set; }
        public int NumberOfItems { get; set; }
        public string BooksIsbn13 { get; set; }

        public virtual BookStore BookStores { get; set; }
        public virtual Book BooksIsbn13Navigation { get; set; }                
    }

 





}
