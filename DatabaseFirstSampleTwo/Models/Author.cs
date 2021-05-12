using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DatabaseFirstSampleTwo.Models
{
    public partial class Author
    {
        private string _firstName;
        private string _lastName;
        public int Id { get; set; }
        [NotMapped]
        public string FullName
        {
            get { return _firstName + " " + _lastName; }
        }
        
        public string AFirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string ALastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime BirthDate { get; set; }
        public bool Active { get; set; }

    }
}
