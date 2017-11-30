using Xamarin.Forms;

namespace XamarinTest01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();

            //            var actionLabel = new Label
            //            {
            //                FontSize = 28,
            //                TextColor = Color.Red,
            //                Text = "WINDOWS_UWP"
            //            };

            //#if WINDOWS_PHONE || WINDOWS_UWP
            //            actionLabel.TextColor = Color.Blue;
            //#endif
            //            MainPage = new ContentPage
            //            {
            //                Content = new StackLayout
            //                {
            //                    Children = { actionLabel }
            //                }
            //            };
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
