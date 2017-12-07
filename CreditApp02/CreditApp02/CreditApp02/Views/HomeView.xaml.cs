using Autofac;
using CreditApp02.Core.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditApp02.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();

            BindingContext = Bootstrapper.Container.Resolve<HomeViewModel>();
        }
    }
}