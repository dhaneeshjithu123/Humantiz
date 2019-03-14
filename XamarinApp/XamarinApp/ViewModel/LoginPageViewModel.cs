using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Humantiz.Controllers;
using Humantiz.Helper.Interface;
namespace Humantiz.ViewModel
{


    public class LoginPageViewModel : ViewModelBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        private readonly Helper.Interface.ICustomNavigationService _navigationService=null;
        
        public LoginPageViewModel( Humantiz.Services.NavigationService navigationService)
        {
            _navigationService = navigationService;
            IsErrorMsgDisplay = false;
            DisplayErrorContentValue = 0;
            IsLoginBtnEnable = false;
            IsRememberMe = false;
        }

        #region "Properties"

        public bool IsErrorMsgDisplay
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool IsLoginBtnEnable
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public bool IsLoading
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public string UserName
        {
            get { return GetValue<string>(); }
            set
            {
                if (IsErrorMsgDisplay)
                    DisplayErrorContentValue = 0;
                IsErrorMsgDisplay = false;
                SetValue(value);
                IsLoginBtnEnable = false;
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(Password))
                {
                    IsLoginBtnEnable = true;
                }
            }
        }

        public string Password
        {
            get { return GetValue<string>(); }
            set
            {
                if (IsErrorMsgDisplay)
                    DisplayErrorContentValue = 0;
                IsErrorMsgDisplay = false;
                SetValue(value);
                IsLoginBtnEnable = false;
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(UserName))
                {
                    IsLoginBtnEnable = true;
                }
            }
        }

       
        

        public ICommand Login_Click
        {
            get
            {
                return new Command(UserLogin);
            }
        }

        public double DisplayErrorContentValue
        {
            get { return GetValue<double>(); }
            set { SetValue(value); }
        }
        public bool IsRememberMe
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }
        #endregion

        #region "Methods"

        /// <summary>
        /// Validate and initialize the login details
        /// </summary>
        public async void UserLogin()
        {
            try
            {
                LoginController loginController = new LoginController();
                IsLoginBtnEnable = false;
                if (await CheckInternetConnection())
                {
                    if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
                    {
                        if (await loginController.CheckLoginDetails(UserName, Password, IsRememberMe))
                        {

                           // await AppFactory.Resolve<INavigationService>().SetRootPage();
                            var mainMasterDetailsPage = new View.MainMasterPage();
                            await _navigationService.NavigateToAsync(mainMasterDetailsPage);

                        }
                        else
                        {
                            IsErrorMsgDisplay = true;
                            DisplayErrorContentValue = 1;
                        }
                    }
                    else
                    {
                        IsErrorMsgDisplay = true;
                        DisplayErrorContentValue = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                IsErrorMsgDisplay = true;
                DisplayErrorContentValue = 1;
            }
            finally
            {
                IsLoginBtnEnable = true;
            }
        }

        /// <summary>
        /// Validates the internet connection
        /// </summary>
        public async Task<bool> CheckInternetConnection()
        {
            //if (!await AppFactory.Resolve<NetworkServiceBase>().IsServerReachable(true))
            //{
            //    LoginErrorMessage = LocalizationResource.InternetErrorMessageText;
            //    IsErrorMsgDisplay = true;
            //    DisplayErrorContentValue = 1;
            //    return false;
            //}
            //else
            //{
            //    IsErrorMsgDisplay = false;
            //    DisplayErrorContentValue = 0;
                return true;
            //}
        }

        #endregion
    }
}
