using Xamarin.Forms;

namespace Humantiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new Humantiz.ViewModel.MainViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            BoxViewDropDown.IsVisible = !BoxViewDropDown.IsVisible;
        }
    }
}
