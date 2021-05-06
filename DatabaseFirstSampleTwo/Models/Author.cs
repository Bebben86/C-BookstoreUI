using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class Author
    {
        public int Id { get; set; }
        public string AFirstName { get; set; }
        public string ALastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
