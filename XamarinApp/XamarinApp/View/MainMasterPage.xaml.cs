using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Humantiz.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterPage : MasterDetailPage
    {
        public MainMasterPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var navPageHomePage = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
            navPageHomePage.BarBackgroundColor = Color.FromHex("#004e75");
            Detail = navPageHomePage;
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {

                var item = e.SelectedItem as MainMasterPageMenuItem;
                if (item == null)
                    return;
                var targetType = item.TargetType;


                switch (item.PageName)
                {

                    case "Home":
                        var navPage = (Page)Activator.CreateInstance(typeof(HomePage));
                        navPage.Title = "Home";
                        Detail = new NavigationPage(navPage);
                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;

                        break;
                    case "Profile":


                        var navPageprofile = (Page)Activator.CreateInstance(typeof(ProfilePage));
                        navPageprofile.Title = "Profile";

                        Detail = new NavigationPage(navPageprofile) ;

                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;

                        break;
                    case "Document":
                        var navPageDocument = (Page)Activator.CreateInstance(typeof(DocumentPage));
                        navPageDocument.Title = "Document";
                        Detail = new NavigationPage( navPageDocument);
                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;


                        break;
                    case "Request":

                        var navPageRequest = (Page)Activator.CreateInstance(typeof(RequestPage));
                        navPageRequest.Title = "Request";
                        Detail = new NavigationPage(navPageRequest) ;
                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;


                        break;
                    case "Inbox":
                        var navPageInboxPage = (Page)Activator.CreateInstance(typeof(InboxPage));
                        navPageInboxPage.Title = "Inbox";
                        Detail = new NavigationPage(navPageInboxPage) ;
                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;


                        break;
                    case "Payslip":
                        var navPagePaySlipPage = (Page)Activator.CreateInstance(typeof(PdfView));
                        navPagePaySlipPage.Title = "Payslip";
                        Detail = new NavigationPage(navPagePaySlipPage);
                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;

                        break;

                    case "Dashboard":
                        var navPageDashboard = (Page)Activator.CreateInstance(typeof(Dashboard));
                        navPageDashboard.Title = "Dashboard";
                        Detail = new NavigationPage(navPageDashboard) ;
                        IsPresented = false;
                        MasterPage.ListView.SelectedItem = null;

                        break;
                    case "Logout":
                        Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(LoginPage)));
                        IsPresented = false;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception EX)
            {

                
            }
        }
    }
}