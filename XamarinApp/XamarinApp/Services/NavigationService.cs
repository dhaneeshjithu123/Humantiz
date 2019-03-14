using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Humantiz.Helper.Interface;

namespace Humantiz.Services
{
    public class NavigationService : ICustomNavigationService
    {


        public void Configure(Page pageKey, Type pageType)
        {
            throw new NotImplementedException();
        }

        public async Task GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();

        }

        public void Initialize(NavigationPage page)
        {

        }

        public async Task NavigateToAsync(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }


        public async Task NavigateTo(Page pageKey, object parameter)
        {

        }

        public async Task PushModayAsync(Page pageKey)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(pageKey);
        }

        public Page GetCurrentPage()
        {
            return Application.Current.MainPage;
        }
    }
}
