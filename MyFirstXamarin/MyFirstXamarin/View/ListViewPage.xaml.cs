using MyFirstXamarin.Data;
using MyFirstXamarin.Model;
using MyFirstXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstXamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public ListViewPage ()
		{
			InitializeComponent ();
            OnRestore(null, null);
            BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EntryPage());
        }

        private void OnRestore(object sender, EventArgs e)
        {
            var repo = new PersonRepository();
            var people = repo.GetAll();
            if(people != null)
                foreach (Person person in people)
                    People.Add(person);
        }
    }
}