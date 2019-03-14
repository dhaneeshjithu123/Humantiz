using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Humantiz.Services;

namespace Humantiz.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RequestPage : ContentPage
	{
		public RequestPage ()
		{
			InitializeComponent ();
            BindingContext = new ViewModel.LeaveRequestViewModel(new Humantiz.Services.NavigationService());
		}
	}
}