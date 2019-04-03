using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Model
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageSource { get; set; }
        public decimal Age { get; set; }

        public Person()
        {
            Name = "Test";
            Address = "Test address";
            ImageSource = "punish.png";
        }

        public Person(string name, string addr, decimal age = 0)
        {
            Name = name;
            Address = addr;
            ImageSource = "punish.png";
            Age = age;
        }
    }
}
