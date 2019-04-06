using MyFirstXamarin.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyFirstXamarin
{
    public partial class App : Application
    {
        static PersonDataBase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static PersonDataBase Database
        {
            get {
                if (database == null)
                {
                    database = new PersonDataBase(
                        DependencyService.Get<IFileHelper>().GetLocalFilePath("PersonSQLite.db3")
                        );
                }
                return database;
            }
        }
    }
}
