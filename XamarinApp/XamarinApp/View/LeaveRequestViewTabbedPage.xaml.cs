using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Humantiz.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LeaveRequestViewTabbedPage : ContentPage
	{
		public LeaveRequestViewTabbedPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new ViewModel.LeaveRequestViewModel();
        }
    }
}