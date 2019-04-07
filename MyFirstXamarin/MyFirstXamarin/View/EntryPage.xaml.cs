﻿using MyFirstXamarin.Data;
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
            var id = 1;
            var repo = new PersonRepository();
            var people = repo.GetAll();
            if (people != null)
                id = people.Count()+1;
            var person = new Person
            {
                Id = id,
                FirstName = entry.FirstName,
                LastName = entry.LastName,
                ImageSource = entry.ImageSource,
                PhoneNumber = entry.PhoneNumber,
                Address = entry.Address,
                Age = entry.Age
            };
            repo.Save(person);

            Navigation.PushAsync(new ListViewPage());
        }
    }
}