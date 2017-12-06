using CreditApp02.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditApp02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel { Navigation = Navigation };
        }
    }
}