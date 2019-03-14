using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Humantiz.Helper.Interface;
using Humantiz.View;

namespace Humantiz.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<MainMasterPageMenuItem> MenuItems { get; set; }

        public MainViewModel()
        {
            GetMenuItems();
        }

        public void GetMenuItems()
        {
            MenuItems = new ObservableCollection<MainMasterPageMenuItem>(new[]
            {

                    new MainMasterPageMenuItem { Id = 0, Title = "Home",Menuimage="home" ,PageName="Home" },
                    new MainMasterPageMenuItem { Id = 0, Title = "Profile",Menuimage="profile" ,PageName="Profile" },
                    new MainMasterPageMenuItem { Id = 1, Title = "Document",Menuimage="document" ,PageName="Document"    },
                    new MainMasterPageMenuItem { Id = 2, Title = "Request",Menuimage="request"   ,PageName="Request"       },
                    new MainMasterPageMenuItem { Id = 3, Title = "Inbox" ,Menuimage="inbox"      ,PageName="Inbox"     },
                    new MainMasterPageMenuItem { Id = 4, Title = "Pay Slip" ,Menuimage="payslip" ,PageName="Payslip"     },
                    new MainMasterPageMenuItem { Id = 7, Title = "Logout" ,Menuimage="logout" ,PageName="Logout"    },

                });
        }

    }


}
