using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Humantiz.Helper.Interface;

namespace Humantiz.ViewModel
{
    public class LeaveRequestViewModel:ViewModelBase
    {
        public LeaveRequestViewModel()
        {
            leavecollection = new List<Leave>();
            Leave obj1 = new Leave();
            obj1.Type = "Anual leave";
            obj1.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj1);
            Leave obj2 = new Leave();
            obj2.Type = "Medical Leave";
            obj2.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj2);
            Leave obj3 = new Leave();
            obj3.Type = "Maternity Leave";
            obj3.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj3);
            Leave obj4 = new Leave();
            obj4.Type = "Festival Leave";
            obj4.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj4);
            Leave obj5 = new Leave();
            obj5.Type = "Emergency leave";
            obj5.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj1);
            Leave obj8 = new Leave();
            obj8.Type = "Sick Leave";
            obj8.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj8);
            Leave obj6 = new Leave();
            obj6.Type = "Maternity Leave";
            obj6.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj6);
            Leave obj7 = new Leave();
            obj7.Type = "Festival Leave";
            obj7.Date = System.DateTime.Now.ToShortDateString();
            leavecollection.Add(obj7);
        }
        public ICommand LeaveRequestCommand { get; private set; }

        private readonly ICustomNavigationService _navigationService;
        public LeaveRequestViewModel(ICustomNavigationService navigationService)
        {
            _navigationService = navigationService;
            var requestTabbedPage = new View.RequestTabbedPage();
            requestTabbedPage.BarBackgroundColor = Color.FromHex("#004e75");
            LeaveRequestCommand = new Command(execute: async () =>
            {
                await NavigateToRequestPageAsync();
            });
        }

        private async Task NavigateToRequestPageAsync()
        {
            var requestTabbedPage = new View.RequestTabbedPage();
            requestTabbedPage.BarBackgroundColor = Color.FromHex("#004e75");
            requestTabbedPage.Title ="Leave Request";

            await _navigationService.NavigateToAsync(requestTabbedPage);
        }

        public List<Leave>leavecollection
        {
            get { return GetValue<List<Leave>>(); }
            set { SetValue(value); }
        }
    }
    public class Leave
    {
        public string Type { get; set; }
        public string Date { get; set; }
    }
}
