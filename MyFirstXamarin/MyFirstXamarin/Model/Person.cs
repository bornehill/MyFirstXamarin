using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ImageSource { get; set; }
        public decimal Age { get; set; }
    }
}
