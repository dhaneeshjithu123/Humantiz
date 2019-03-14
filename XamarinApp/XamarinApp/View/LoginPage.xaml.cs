
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Humantiz.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new ViewModel.LoginPageViewModel(new Humantiz.Services.NavigationService());
        }


    }
}