using MyFirstXamarin.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstXamarin.Data
{
    public class PersonRepository : GenericFileRepository<Person>
    {
        public PersonRepository(): base("PersonFile.json")
        {

        }
    }
}
