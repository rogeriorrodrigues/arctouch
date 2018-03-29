using movies.ViewModels;
using movies.Views;
using Xamarin.Forms;

namespace movies
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            MainPage = new MoviesTabbedPage();
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
    }
}
