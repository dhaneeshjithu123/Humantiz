
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterPageDetail : ContentPage
    {
        public MainMasterPageDetail()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}