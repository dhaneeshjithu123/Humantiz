using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace Humantiz.Droid
{
    [Activity(Label = "Humanitiz", Icon = "@drawable/AppIcon", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash",
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    internal class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }


}