using Xamarin.Forms;

namespace XamarinTest01
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            var header = new Label { Text = "Привет из Xamarin Forms" };
            Content = header;
        }
    }
}
