using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Humantiz.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        private readonly Helper.Interface.ICustomNavigationService _navigationService = null;

        public HomeViewModel(Humantiz.Services.NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand Loan_Click
        {
            get
            {
                return new Command(GotoLoan);
            }
        }



        #region "Methods"
        public async void GotoLoan()
        {
            try
            {

                var LoanPage = new View.GratuityViewPage();
                LoanPage.Title = "Loan Page";
                await _navigationService.NavigateToAsync(LoanPage);

            }
            catch (Exception)
            {
            }

        }


        #endregion
    }
}
