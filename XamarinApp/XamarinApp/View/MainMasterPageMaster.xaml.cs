using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Humantiz.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MainMasterPageMaster()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
         
            BindingContext = new ViewModel.MainViewModel();
            ListView = MenuItemsListView;
        }

         
    }
}