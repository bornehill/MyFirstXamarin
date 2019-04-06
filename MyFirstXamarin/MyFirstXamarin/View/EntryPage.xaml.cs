using MyFirstXamarin.Model;
using MyFirstXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstXamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
        EntryVM entry;
		public EntryPage ()
		{
			InitializeComponent ();
            entry = new EntryVM();
            BindingContext = entry;
		}

        private void AddPerson(object sender, EventArgs e)
        {
            entry.AddToPeople();
            Navigation.PushAsync(new ListViewPage());
        }
    }
}