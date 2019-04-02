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
	public partial class SliderPage : ContentPage
	{
		public SliderPage ()
		{
			InitializeComponent ();
            BindingContext = new SliceVM();
		}
	}
}