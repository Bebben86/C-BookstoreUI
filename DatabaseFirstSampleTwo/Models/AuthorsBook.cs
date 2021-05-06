using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class AuthorsBook
    {
        public int AuthorsId { get; set; }
        public string BooksIsbn13 { get; set; }

        public virtual Author Authors { get; set; }
        public virtual Book BooksIsbn13Navigation { get; set; }
    }
}
