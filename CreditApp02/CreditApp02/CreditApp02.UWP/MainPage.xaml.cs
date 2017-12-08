namespace CreditApp02.UWP
{
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new Core.UWP.App());
        }
    }
}
