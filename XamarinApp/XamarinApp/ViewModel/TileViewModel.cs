using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Humantiz.Helper.Interface;

namespace Humantiz.ViewModel
{
    public class TileViewModel
    {
        private readonly ICustomNavigationService _navigationService;
        public ICommand LoanCommand { get; set; }

        public TileViewModel(ICustomNavigationService navigationService)
        {
            _navigationService = navigationService;
            LoanCommand = new Command(execute: async () =>
            {
             // await  NavigateLoanPage();
            });
        }

        private void NavigateLoanPage()
        {

          //  ( _navigationService.GetCurrentPage()as MasterDetailPage).Detail =new NavigationPage( new View.LoanBalance());

        }
    }
}
