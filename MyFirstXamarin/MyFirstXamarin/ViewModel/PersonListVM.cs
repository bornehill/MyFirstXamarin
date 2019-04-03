using MyFirstXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static System.Math;

namespace MyFirstXamarin.ViewModel
{
    class PersonListVM
    {
        public ObservableCollection<Person> People { get; set; }  = new ObservableCollection<Person>();

        public PersonListVM()
        {
            string[] names = { "Juan", "Pedro", "Cloe" };
            string[] addresses = { "Palomino", "Santiago", "Villa Juana" };

            var ram = new Random();

            for (int pos = 0; pos < 3; pos++)
                People.Add(new Person(names[pos], addresses[pos], (decimal)(pos + 18 * ram.NextDouble())));
        }
    }
}
