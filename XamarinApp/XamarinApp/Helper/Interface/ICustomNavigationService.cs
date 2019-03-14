using System;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Humantiz.Helper.Interface
{
    public interface ICustomNavigationService
    {
        Task GoBack();
        Task NavigateToAsync(Page pageKey);
        Task NavigateTo(Page pageKey, object parameter);
        Task PushModayAsync(Page pageKey);
        Page GetCurrentPage();

        void Configure(Page pageKey, Type pageType);
        void Initialize(NavigationPage page);
    }
}
