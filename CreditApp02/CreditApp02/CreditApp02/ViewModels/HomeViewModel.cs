using CreditApp02.ViewModels.Base;

namespace CreditApp02.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private string _name;

        public HomeViewModel()
        {
            Name = "Alex";
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    }
}
