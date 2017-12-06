using Study02.Views;
using Xamarin.Forms;

namespace Study02
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var homePage = Bootstrapper.Instance.Resolve<HomePage>();
            MainPage = homePage;
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
