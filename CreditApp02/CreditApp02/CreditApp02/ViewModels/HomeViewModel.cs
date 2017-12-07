using CreditApp02.Infrastructure.Data;
using CreditApp02.ViewModels.Base;

namespace CreditApp02.Core.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly IDatabaseManager _databaseManager;
        private string _name;
        

        public HomeViewModel()
        {
           // _databaseManager = databaseManager;


            Name = "AlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlexAlex";
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

        public override void OnAppearing()
        {
            base.OnAppearing();

            _databaseManager.ConfigureAsync();
        }
    }
}
