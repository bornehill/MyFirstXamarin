using MyFirstXamarin.Internationalization.Resx;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstXamarin.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectLanguagePage : ContentPage
	{
		public SelectLanguagePage ()
		{
			InitializeComponent ();
		}

        private void OnSpanish(object sender, EventArgs e)
        {
            SwitchLanguage("es-MX");
        }

        private void OnEnglish(object sender, EventArgs e)
        {
            SwitchLanguage("en-US");
        }

        private void SwitchLanguage(string code)
        {
            var cultureInfo = new CultureInfo(code);
            ((App)Application.Current).Culture = cultureInfo;
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            AppResources.Culture = cultureInfo;
            Navigation.PushAsync(new InternationalPage());
        }
    }
}