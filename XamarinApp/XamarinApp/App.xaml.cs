using Newtonsoft.Json;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Humantiz.Interfaces;
using Humantiz.Model;
using Humantiz.View;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Humantiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
             CheckLogin();
        }



        public static Page GetMainPage()
        {
            return new MainPage();
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected async void  CheckLogin()
        {
            IFileReadWrite fileReadWrite = Xamarin.Forms.DependencyService.Get<IFileReadWrite>();
            LoginUserDetail serialized = new LoginUserDetail();
            string userDetails = await fileReadWrite.ReadFromFile();
            if (string.IsNullOrEmpty(userDetails))
            {
                var firstPage = new NavigationPage(new LoginPage());
                MainPage = firstPage;
            }
            else
            {
                serialized = JsonConvert.DeserializeObject<LoginUserDetail>(userDetails);
                if (serialized == null)
                {
                    var firstPage = new NavigationPage(new LoginPage());
                    MainPage = firstPage;
                }
                else
                {
                    var firstPage = new NavigationPage(new MainMasterPage());
                    MainPage = firstPage;

                }

            }


        }
    }
}
