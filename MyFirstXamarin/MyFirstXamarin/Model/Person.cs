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

        public Person()
        {
            Name = "Test";
            Address = "Test address";
            ImageSource = "punish.png";
        }

        public Person(string name, string addr)
        {
            Name = name;
            Address = addr;
            ImageSource = "punish.png";
        }
    }
}
