using CreditApp02.ViewModels.Base;

namespace CreditApp02.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            IntroLabel = "Alex";
        }

        public string IntroLabel { get; set; }
    }
}
