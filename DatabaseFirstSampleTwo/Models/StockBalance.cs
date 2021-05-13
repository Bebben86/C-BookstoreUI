using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class StockBalance
    {
        [Key, Column(Order = 0)]
        public int BookStoresId { get; set; }
        
        [Key, Column(Order = 1)]
        public string BooksIsbn13 { get; set; }
        public int NumberOfItems { get; set; }

        public virtual BookStore BookStores { get; set; }
        public virtual Book BooksIsbn13Navigation { get; set; }                
    }

 





}
