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
            PopulatePeople();
            ItemSelectedCommand = new Command<Person>(HandleItemSelected);
        }

        private async void PopulatePeople()
        {
            try
            {
                List<Person> people = await App.Database.GetPeopleAsync();
                foreach (Person person in people)
                    People.Add(person);
            }
            catch (Exception e)
            { }
        }

        private void HandleItemSelected(Person person)
        {
            SelectedItemText = $"{person.FirstName}";
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
