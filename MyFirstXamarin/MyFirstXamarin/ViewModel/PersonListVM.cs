using MyFirstXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using static System.Math;

namespace MyFirstXamarin.ViewModel
{
    class PersonListVM : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; set; }  = new ObservableCollection<Person>();
        public ICommand ItemSelectedCommand { get; private set; }

        private string selectedItemText;
        public string SelectedItemText
        {
            get { return selectedItemText; }
            set
            {
                selectedItemText = value;
                RaisePropertyChanged();
            }
        }

        public PersonListVM()
        {
            string[] names = { "Juan", "Pedro", "Cloe" };
            string[] addresses = { "Palomino", "Santiago", "Villa Juana" };

            var ram = new Random();

            for (int pos = 0; pos < 3; pos++)
                People.Add(new Person(names[pos], addresses[pos], (decimal)(pos + 18 * ram.NextDouble())));

            ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        }

        private void HandleItemSelected(Person person)
        {
            SelectedItemText = $"{person.Name}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
