using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class TitlesPerAuthor
    {
        public string Author { get; set; }
        public int? Age { get; set; }
        public int? NoOfTitles { get; set; }
        public decimal? StockValue { get; set; }
    }
}
