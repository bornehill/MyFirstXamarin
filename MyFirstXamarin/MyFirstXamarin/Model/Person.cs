using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Model
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {
            Name = "Test";
            Address = "Test address";
        }

        public Person(string name, string addr)
        {
            Name = name;
            Address = addr;
        }
    }
}
