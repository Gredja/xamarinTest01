using CreditApp02.Core.Views;
using CreditApp02.Infrastructure.Data.Repositories.Interfaces;
using Xamarin.Forms;

namespace CreditApp02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Bootstrapper.Instance.Initialize();

            MainPage = new NavigationPage(new HomeView()); 
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
