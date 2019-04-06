using MyFirstXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.ViewModel
{
    class EntryVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ImageSource { get; set; }
        public decimal Age { get; set; }

        public void AddToPeople()
        {
            Person person = new Person
            {
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Address = Address,
                ImageSource = ImageSource,
                Age = Age
            };
            App.Database.SavePersonAsync(person);
        }
    }
}
