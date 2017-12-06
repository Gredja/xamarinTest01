
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CreditApp02.Annotations;
using Xamarin.Forms;

namespace CreditApp02.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        private void Back()
        {
            Navigation.PopAsync();
        }
    }
}
