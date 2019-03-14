using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Humantiz.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentView
    {

        
        public Dashboard()
        {
            InitializeComponent();
            BindingContext = new ViewModel.DashBoardViewmodel();

        }
        
    }
}
